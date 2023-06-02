namespace PcTimeCalculator.Logger
{
    public interface ILogger
    {
        List<string> Data { get; }

        public void Info(string message);
        public void Warn(string message);
        public void Error(string message);
    }
}
