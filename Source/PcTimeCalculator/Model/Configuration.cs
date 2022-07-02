namespace PcTimeCalculator.Model
{
    /// <summary>
    /// Class to perform deserialization from json.
    /// </summary>
    public class Configuration
    {
        public double WorkTimeDuration { get; set; }
        public double PauseDuration { get; set; }

        public Configuration()
        { }
    }
}
