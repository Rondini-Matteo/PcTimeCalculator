using System.Media;

namespace PcTimeCalculator.View
{
    public partial class MainForm : Form
    {
        private Controller controller;
        private LoggerViewer loggerViewer;

        private delegate void voidMethodDelegate();

        private int currentTime = 0;

        public MainForm()
        {
            InitializeComponent();

            this.Disposed += MainForm_Disposed;

            controller = new Controller();

            loggerViewer = new LoggerViewer(controller.GetLogger());

            controller.OnPauseStarted += Controller_OnPauseStarted;
            controller.OnPauseEnded += Controller_OnPauseEnded;
            controller.OnUserInactivity += Controller_OnUserInactivity;
            Controller_OnPauseEnded();
        }

        private void MainForm_Disposed(object? sender, EventArgs e)
        {
            controller.ApplicationRunning = false;
            timer1s.Stop();
            timer1s.Enabled = false;
            timer1s.Dispose();
        }

        private void Controller_OnPauseEnded()
        {
            if (!InvokeRequired)
            {
                lblStatus.Text = "WORKING";
                lblStatus.BackColor = Color.OrangeRed;
                btnStartToWork.Enabled = false;
                btnTakeABreak.Enabled = true;

                ShowWorkTime();
                StartProgressBar((int)controller.GetWorkTimeDuration());
                ShowTimeRemaining(controller.GetWorkSecondsRemaining());
            }
            else BeginInvoke(Controller_OnPauseEnded);
        }

        private void Controller_OnPauseStarted()
        {
            if (!InvokeRequired)
            {
                lblStatus.Text = "ON BREAK";
                lblStatus.BackColor = Color.LimeGreen;
                btnStartToWork.Enabled = true;
                btnTakeABreak.Enabled = false;

                SystemSounds.Exclamation.Play();

                ShowPauseTime();
                StartProgressBar((int)controller.GetPauseDuration());
                ShowTimeRemaining(controller.GetPauseSecondsRemaining());

                Activate();
                BringToFront();
            }
            else BeginInvoke(Controller_OnPauseStarted);
        }

        private void Controller_OnUserInactivity()
        {
            if (!InvokeRequired)
            {
                lblStatus.Text = "INACTIVITY";
                lblStatus.BackColor = Color.LimeGreen;
                btnStartToWork.Enabled = true;
                btnTakeABreak.Enabled = false;

                ShowNoTime();
                progressBar.Value = 0;
                timer1s.Stop();
            }
            else BeginInvoke(Controller_OnUserInactivity);
        }

        private void BtnTakeABreak_Click(object sender, EventArgs e)
        {
            controller.TakeABreak();
        }

        private void BtnStartToWork_Click(object sender, EventArgs e)
        {
            controller.StartToWork();
        }

        private void ShowWorkTime()
        {
            if (!InvokeRequired)
            {
                lblWorkTimeStart.Text = controller.GetWorkTimeStart().ToLongTimeString();
                lblWorkTimeEnd.Text = controller.GetWorkTimeEnd().ToLongTimeString();
                lblPauseTimeStart.Text = string.Empty;
                lblPauseTimeEnd.Text = string.Empty;
            }
            else BeginInvoke(new voidMethodDelegate(ShowWorkTime));
        }

        private void ShowPauseTime()
        {
            if (!InvokeRequired)
            {
                lblWorkTimeStart.Text = string.Empty;
                lblWorkTimeEnd.Text = string.Empty;
                lblPauseTimeStart.Text = controller.GetPauseTimeStart().ToLongTimeString();
                lblPauseTimeEnd.Text = controller.GetPauseTimeEnd().ToLongTimeString();
            }
            else BeginInvoke(new voidMethodDelegate(ShowWorkTime));
        }

        private void ShowNoTime()
        {
            if (!InvokeRequired)
            {
                lblWorkTimeStart.Text = string.Empty;
                lblWorkTimeEnd.Text = string.Empty;
                lblPauseTimeStart.Text = string.Empty;
                lblPauseTimeEnd.Text = string.Empty;
            }
            else BeginInvoke(new voidMethodDelegate(ShowNoTime));
        }

        private void ShowTimeRemaining(int timeRemaining)
        {
            if (!InvokeRequired)
            {
                currentTime = timeRemaining;
                lblTimeRemaining.Text = string.Format("{0} seconds left", currentTime);
            }
            else
                BeginInvoke(new Action(() => ShowTimeRemaining(timeRemaining)));
        }

        private void StartProgressBar(int maximum)
        {
            progressBar.Value = 0;
            progressBar.Maximum = maximum;
            timer1s.Start();
        }

        private void Timer1Seconds_Tick(object sender, EventArgs e)
        {
            if (!InvokeRequired)
            {
                progressBar.Increment(1);

                if (progressBar.Value == progressBar.Maximum)
                    timer1s.Stop();

                currentTime -= 1;
                lblTimeRemaining.Text = string.Format("{0} seconds left", currentTime);
            }
            else
                BeginInvoke(Timer1Seconds_Tick);
        }

        private void LblStatus_Click(object sender, EventArgs e)
        {
            if (loggerViewer != null)
            {
                loggerViewer.LoadHistory();
                loggerViewer.Show(this);
            }
        }

    }
}
