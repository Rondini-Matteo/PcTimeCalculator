using PcTimeCalculator.Logger;
using System.Text;

namespace PcTimeCalculator.View
{
    public partial class LoggerViewer : Form
    {
        ILogger logger;

        public LoggerViewer()
        {
            InitializeComponent();
            Shown += LoggerViewer_Shown;
        }

        public LoggerViewer(ILogger logger) : this()
        {
            this.logger = logger;
        }

        public void LoadHistory()
        {
            StringBuilder stringBuilder = new();

            if (logger != null)
            {
                foreach (string line in logger.Data)
                {
                    stringBuilder.AppendLine(line);
                }

                stringBuilder.AppendLine();
                TextBox.Text = stringBuilder.ToString();
                stringBuilder.Clear();
            }

            CenterToParent();
        }

        private void LoggerViewer_Shown(object? sender, EventArgs e)
        {
            CenterToParent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            Hide();
        }

    }
}
