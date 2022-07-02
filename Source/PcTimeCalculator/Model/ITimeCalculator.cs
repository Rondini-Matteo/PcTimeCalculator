namespace PcTimeCalculator.Model
{
    public interface ITimeCalculator
    {
        public DateTime WorkTimeStart { get; }
        public DateTime WorkTimeEnd { get; }
        public double WorkTimeDuration { get; }

        public DateTime BreakTimeStart { get; }
        public DateTime BreakTimeEnd { get; }
        public double PauseDuration { get; }

        public void StartToWork();

        public void TakeABreak();

        public bool IsTimeToTakeABreak();

        public bool IsTimeToGoBackToWork();

    }
}
