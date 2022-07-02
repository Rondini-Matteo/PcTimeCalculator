namespace PcTimeCalculator
{
    public class Controller
    {
        public delegate void OnPauseStartedDelegate();
        public delegate void OnPauseEndedDelegate();

        public event OnPauseStartedDelegate? OnPauseStarted;
        public event OnPauseEndedDelegate? OnPauseEnded;

        public bool ApplicationRunning { get; set; }

        private Model.ITimeCalculator calculator;

        public Controller()
        {
            calculator = new Model.TimeCalculator();
            ApplicationRunning = true;
            StartToWork();
            CheckTime();
        }

        #region Getters

        public DateTime GetWorkTimeStart()
        {
            return calculator.WorkTimeStart.ToLocalTime();
        }

        public DateTime GetWorkTimeEnd()
        {
            return calculator.WorkTimeEnd.ToLocalTime();
        }

        public DateTime GetPauseTimeStart()
        {
            return calculator.BreakTimeStart.ToLocalTime();
        }

        public DateTime GetPauseTimeEnd()
        {
            return calculator.BreakTimeEnd.ToLocalTime();
        }

        #endregion

        public void StartToWork()
        {
            calculator.StartToWork();
        }

        public void TakeABreak()
        {
            calculator.TakeABreak();
        }

        private void CheckTime()
        {
            Thread t = new Thread(() =>
            {
                while (ApplicationRunning)
                {
                    if (calculator.IsTimeToTakeABreak())
                    {
                        TakeABreak();
                        OnPauseStarted?.Invoke();
                    }

                    if (calculator.IsTimeToGoBackToWork())
                    {
                        StartToWork();
                        OnPauseEnded?.Invoke();
                    }

                    Thread.Sleep(1000);
                }
            });

            t.Start();
        }

    }
}
