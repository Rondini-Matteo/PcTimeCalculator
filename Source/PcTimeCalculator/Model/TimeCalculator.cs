using System.Text.Json;

namespace PcTimeCalculator.Model
{
    public class TimeCalculator : ITimeCalculator
    {
        public DateTime WorkTimeStart { get; private set; }
        public DateTime WorkTimeEnd { get; private set; }
        public double WorkTimeDuration { get; private set; }

        public DateTime BreakTimeStart { get; private set; }
        public DateTime BreakTimeEnd { get; private set; }
        public double PauseDuration { get; private set; }

        private object _lock = new();

        public TimeCalculator()
        {
            LoadConfiguration();
        }

        public void StartToWork()
        {
            lock (_lock)
            {
                WorkTimeStart = DateTime.Now;
                WorkTimeEnd = WorkTimeStart.AddSeconds(WorkTimeDuration);

                BreakTimeStart = WorkTimeStart.AddSeconds(WorkTimeDuration);
                BreakTimeEnd = BreakTimeStart.AddSeconds(PauseDuration);
            }
        }

        public void TakeABreak()
        {
            lock (_lock)
            {
                WorkTimeStart = DateTime.Now.AddSeconds(PauseDuration);
                WorkTimeEnd = WorkTimeStart.AddSeconds(WorkTimeDuration);

                BreakTimeStart = DateTime.Now;
                BreakTimeEnd = BreakTimeStart.AddSeconds(PauseDuration);
            }
        }

        public bool IsTimeToTakeABreak()
        {
            lock (_lock)
            {
                return (DateTime.Now - WorkTimeEnd).TotalMilliseconds > 0;
            }
        }

        public bool IsTimeToGoBackToWork()
        {
            lock (_lock)
            {
                return (DateTime.Now - BreakTimeEnd).TotalMilliseconds > 0;
            }
        }

        public double GetWorkTimeRemaining()
        {
            return (WorkTimeEnd - DateTime.Now).TotalSeconds;
        }

        public double GetPauseTimeRemaining()
        {
            return (BreakTimeEnd - DateTime.Now).TotalSeconds;
        }

        private void LoadConfiguration()
        {
            string configPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Config\\Configuration.json");

            Configuration? configuration = null;

            if (File.Exists(configPath))
            {
                configuration = JsonSerializer.Deserialize<Configuration>(File.ReadAllText(configPath));

                if (configuration != null)
                {
                    WorkTimeDuration = configuration.WorkTimeDuration;
                    PauseDuration = configuration.PauseDuration;
                }
            }

            if (configuration == null)
            {
                //Default value
                WorkTimeDuration = 7200;
                PauseDuration = 900;
            }
        }

    }
}
