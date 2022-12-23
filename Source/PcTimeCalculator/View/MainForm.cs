namespace PcTimeCalculator.View
{
    public partial class MainForm : Form
    {
        private Controller controller;

        private delegate void voidMethodDelegate();

        public MainForm()
        {
            InitializeComponent();

            this.Disposed += MainForm_Disposed;

            controller = new Controller();

            controller.OnPauseStarted += Controller_OnPauseStarted;
            controller.OnPauseEnded += Controller_OnPauseEnded;
            Controller_OnPauseEnded();
        }

        private void MainForm_Disposed(object? sender, EventArgs e)
        {
            controller.ApplicationRunning = false;
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
                ShowPauseTime();
                
                Activate();
                BringToFront();
            }
            else BeginInvoke(Controller_OnPauseStarted);
        }

        private void BtnTakeABreak_Click(object sender, EventArgs e)
        {
            controller.TakeABreak();
            Controller_OnPauseStarted();
        }

        private void BtnStartToWork_Click(object sender, EventArgs e)
        {
            controller.StartToWork();
            Controller_OnPauseEnded();
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

    }
}
