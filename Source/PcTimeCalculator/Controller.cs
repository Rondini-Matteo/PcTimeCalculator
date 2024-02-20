using PcTimeCalculator.Logger;
using PcTimeCalculator.Model;

namespace PcTimeCalculator
{
    public class Controller
    {
        public delegate void OnPauseStartedDelegate();
        public delegate void OnPauseEndedDelegate();
        public delegate void OnUserInactivityDelegate();

        public event OnPauseStartedDelegate? OnPauseStarted;
        public event OnPauseEndedDelegate? OnPauseEnded;
        public event OnUserInactivityDelegate? OnUserInactivity;

        public bool ApplicationRunning { get; set; }
        public bool IsUserInactive { get; private set; }
        private bool isStartToWorkRequired;

        private ITimeCalculator calculator;
        private ILogger logger;

        public Controller()
        {
            calculator = new TimeCalculator();
            logger = new MemoryLogger();

            ApplicationRunning = true;
            IsUserInactive = false;
            isStartToWorkRequired = false;

            StartToWork();
            CheckTime();
            CheckUserActivity();
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

        public double GetWorkTimeDuration()
        {
            return calculator.WorkTimeDuration;
        }

        public double GetPauseDuration()
        {
            return calculator.PauseDuration;
        }

        public int GetWorkSecondsRemaining()
        {
            return (int)calculator.GetWorkTimeRemaining();
        }

        public int GetPauseSecondsRemaining()
        {
            return (int)calculator.GetPauseTimeRemaining();
        }

        public ILogger GetLogger()
        {
            return logger;
        }

        #endregion Getters

        public void StartToWork()
        {
            calculator.StartToWork();
            OnPauseEnded?.Invoke();
            logger.Info("StartToWork()");
        }

        public void TakeABreak()
        {
            calculator.TakeABreak();
            OnPauseStarted?.Invoke();
            logger.Info("TakeABreak()");
        }

        private void CheckTime()
        {
            Task.Factory.StartNew(() =>
            {
                while (ApplicationRunning)
                {
                    if (!IsUserInactive)
                    {
                        if (calculator.IsTimeToTakeABreak())
                            TakeABreak();

                        if (calculator.IsTimeToGoBackToWork())
                            StartToWork();
                    }

                    Thread.Sleep(1000);
                }
            });
        }

        private void CheckUserActivity()
        {
            Task.Factory.StartNew(() =>
            {
                while (ApplicationRunning)
                {
                    TimeSpan timespent = TimeSpan.FromMilliseconds(UserActivity.GetLastActivity());

                    if (timespent.TotalSeconds >= calculator.PauseDuration)
                    {
                        IsUserInactive = true;

                        if (!isStartToWorkRequired)
                            logger.Info("User inactivity detected");

                        isStartToWorkRequired = true;
                        OnUserInactivity?.Invoke();
                    }
                    else
                    {
                        if (isStartToWorkRequired)
                        {
                            StartToWork();
                            IsUserInactive = false;
                            isStartToWorkRequired = false;
                        }
                    }

                    Thread.Sleep(10000);
                }
            });
        }

    }
}
