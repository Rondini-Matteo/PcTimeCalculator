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
            WorkTimeDuration = 7200;
            PauseDuration = 900;
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

    }
}
