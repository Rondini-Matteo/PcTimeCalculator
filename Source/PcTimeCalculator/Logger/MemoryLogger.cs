namespace PcTimeCalculator.Logger
{
    public class MemoryLogger : ILogger
    {
        public List<string> Data { get; private set; }

        private const string timeFormat = "dd/M/yyyy HH:mm";

        public MemoryLogger()
        {
            Data = new List<string>();
        }

        private void AddMessage(string message)
        {
            if (Data.Count > 50)
                Data.RemoveAt(0);

            Data.Add(message);
        }

        #region ILogger Methods

        public void Info(string message)
        {
            Console.WriteLine($"INFO - {DateTime.Now.ToString(timeFormat)}: {message}");
            AddMessage($"INFO - {DateTime.Now.ToString(timeFormat)}: {message}");
        }

        public void Warn(string message)
        {
            Console.WriteLine($"WARNING - {DateTime.Now.ToString(timeFormat)}: {message}");
            AddMessage($"WARNING - {DateTime.Now.ToString(timeFormat)}: {message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"ERROR - {DateTime.Now.ToString(timeFormat)}: {message}");
            AddMessage($"ERROR - {DateTime.Now.ToString(timeFormat)}: {message}");
        }

        #endregion ILogger Methods

    }
}
