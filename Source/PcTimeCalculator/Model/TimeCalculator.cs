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

        public TimeCalculator()
        {
            LoadConfiguration();
        }

        public void StartToWork()
        {
            WorkTimeStart = DateTime.Now;
            WorkTimeEnd = WorkTimeStart.AddSeconds(WorkTimeDuration);

            BreakTimeStart = WorkTimeStart.AddSeconds(WorkTimeDuration);
            BreakTimeEnd = BreakTimeStart.AddSeconds(PauseDuration);
        }

        public void TakeABreak()
        {
            WorkTimeStart = DateTime.Now.AddSeconds(PauseDuration);
            WorkTimeEnd = WorkTimeStart.AddSeconds(WorkTimeDuration);

            BreakTimeStart = DateTime.Now;
            BreakTimeEnd = BreakTimeStart.AddSeconds(PauseDuration);
        }

        public bool IsTimeToTakeABreak()
        {
            return (DateTime.Now - WorkTimeEnd).TotalMilliseconds > 0;
        }

        public bool IsTimeToGoBackToWork()
        {
            return (DateTime.Now - BreakTimeEnd).TotalMilliseconds > 0;
        }

        private void LoadConfiguration()
        {
            string configPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Config\\Configuration.json");

            if (File.Exists(configPath))
            {
                Configuration? configuration = JsonSerializer.Deserialize<Configuration>(File.ReadAllText(configPath));

                if (configuration != null)
                {
                    WorkTimeDuration = configuration.WorkTimeDuration;
                    PauseDuration = configuration.PauseDuration;
                }
                else
                {
                    //Default value
                    WorkTimeDuration = 7200;
                    PauseDuration = 900;
                }
            }
        }

    }
}
