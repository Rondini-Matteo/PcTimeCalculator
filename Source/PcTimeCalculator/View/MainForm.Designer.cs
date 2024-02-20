namespace PcTimeCalculator.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tlpGeneral = new TableLayoutPanel();
            lblTimeRemaining = new Label();
            groupBoxWorkTime = new GroupBox();
            tlpWorkTime = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            lblWorkTimeStart = new Label();
            lblWorkTimeEnd = new Label();
            groupBoxBreakTime = new GroupBox();
            tlpBreakTime = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            lblPauseTimeStart = new Label();
            lblPauseTimeEnd = new Label();
            tlpFooter = new TableLayoutPanel();
            btnTakeABreak = new Button();
            lblStatus = new Label();
            btnStartToWork = new Button();
            progressBar = new ProgressBar();
            timer1s = new System.Windows.Forms.Timer(components);
            tlpGeneral.SuspendLayout();
            groupBoxWorkTime.SuspendLayout();
            tlpWorkTime.SuspendLayout();
            groupBoxBreakTime.SuspendLayout();
            tlpBreakTime.SuspendLayout();
            tlpFooter.SuspendLayout();
            SuspendLayout();
            // 
            // tlpGeneral
            // 
            tlpGeneral.ColumnCount = 2;
            tlpGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpGeneral.Controls.Add(lblTimeRemaining, 1, 2);
            tlpGeneral.Controls.Add(groupBoxWorkTime, 0, 0);
            tlpGeneral.Controls.Add(groupBoxBreakTime, 0, 1);
            tlpGeneral.Controls.Add(tlpFooter, 0, 3);
            tlpGeneral.Controls.Add(progressBar, 0, 2);
            tlpGeneral.Dock = DockStyle.Fill;
            tlpGeneral.Location = new Point(0, 0);
            tlpGeneral.Name = "tlpGeneral";
            tlpGeneral.Padding = new Padding(5, 0, 5, 0);
            tlpGeneral.RowCount = 4;
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpGeneral.Size = new Size(802, 463);
            tlpGeneral.TabIndex = 0;
            // 
            // lblTimeRemaining
            // 
            lblTimeRemaining.AutoSize = true;
            lblTimeRemaining.BorderStyle = BorderStyle.Fixed3D;
            lblTimeRemaining.Dock = DockStyle.Fill;
            lblTimeRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTimeRemaining.Location = new Point(562, 279);
            lblTimeRemaining.Margin = new Padding(3);
            lblTimeRemaining.Name = "lblTimeRemaining";
            lblTimeRemaining.Size = new Size(232, 40);
            lblTimeRemaining.TabIndex = 4;
            lblTimeRemaining.Text = "- seconds left";
            lblTimeRemaining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxWorkTime
            // 
            tlpGeneral.SetColumnSpan(groupBoxWorkTime, 2);
            groupBoxWorkTime.Controls.Add(tlpWorkTime);
            groupBoxWorkTime.Dock = DockStyle.Fill;
            groupBoxWorkTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxWorkTime.Location = new Point(8, 3);
            groupBoxWorkTime.Name = "groupBoxWorkTime";
            groupBoxWorkTime.Padding = new Padding(10, 3, 10, 3);
            groupBoxWorkTime.Size = new Size(786, 132);
            groupBoxWorkTime.TabIndex = 0;
            groupBoxWorkTime.TabStop = false;
            groupBoxWorkTime.Text = "Work Time:";
            // 
            // tlpWorkTime
            // 
            tlpWorkTime.ColumnCount = 2;
            tlpWorkTime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpWorkTime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpWorkTime.Controls.Add(label1, 0, 0);
            tlpWorkTime.Controls.Add(label2, 0, 1);
            tlpWorkTime.Controls.Add(lblWorkTimeStart, 1, 0);
            tlpWorkTime.Controls.Add(lblWorkTimeEnd, 1, 1);
            tlpWorkTime.Dock = DockStyle.Fill;
            tlpWorkTime.Location = new Point(10, 23);
            tlpWorkTime.Name = "tlpWorkTime";
            tlpWorkTime.RowCount = 2;
            tlpWorkTime.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpWorkTime.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpWorkTime.Size = new Size(766, 106);
            tlpWorkTime.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(530, 47);
            label1.TabIndex = 0;
            label1.Text = "Work Time Start:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(3, 56);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(530, 47);
            label2.TabIndex = 1;
            label2.Text = "Work Time Stop:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWorkTimeStart
            // 
            lblWorkTimeStart.AutoSize = true;
            lblWorkTimeStart.BackColor = Color.Coral;
            lblWorkTimeStart.BorderStyle = BorderStyle.Fixed3D;
            lblWorkTimeStart.Dock = DockStyle.Fill;
            lblWorkTimeStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblWorkTimeStart.Location = new Point(539, 3);
            lblWorkTimeStart.Margin = new Padding(3);
            lblWorkTimeStart.Name = "lblWorkTimeStart";
            lblWorkTimeStart.Size = new Size(224, 47);
            lblWorkTimeStart.TabIndex = 2;
            lblWorkTimeStart.Text = "00:00:00";
            lblWorkTimeStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWorkTimeEnd
            // 
            lblWorkTimeEnd.AutoSize = true;
            lblWorkTimeEnd.BackColor = Color.OrangeRed;
            lblWorkTimeEnd.BorderStyle = BorderStyle.Fixed3D;
            lblWorkTimeEnd.Dock = DockStyle.Fill;
            lblWorkTimeEnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblWorkTimeEnd.Location = new Point(539, 56);
            lblWorkTimeEnd.Margin = new Padding(3);
            lblWorkTimeEnd.Name = "lblWorkTimeEnd";
            lblWorkTimeEnd.Size = new Size(224, 47);
            lblWorkTimeEnd.TabIndex = 3;
            lblWorkTimeEnd.Text = "00:00:00";
            lblWorkTimeEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxBreakTime
            // 
            tlpGeneral.SetColumnSpan(groupBoxBreakTime, 2);
            groupBoxBreakTime.Controls.Add(tlpBreakTime);
            groupBoxBreakTime.Dock = DockStyle.Fill;
            groupBoxBreakTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxBreakTime.Location = new Point(8, 141);
            groupBoxBreakTime.Name = "groupBoxBreakTime";
            groupBoxBreakTime.Padding = new Padding(10, 3, 10, 3);
            groupBoxBreakTime.Size = new Size(786, 132);
            groupBoxBreakTime.TabIndex = 1;
            groupBoxBreakTime.TabStop = false;
            groupBoxBreakTime.Text = "Break:";
            // 
            // tlpBreakTime
            // 
            tlpBreakTime.ColumnCount = 2;
            tlpBreakTime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpBreakTime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpBreakTime.Controls.Add(label3, 0, 0);
            tlpBreakTime.Controls.Add(label4, 0, 1);
            tlpBreakTime.Controls.Add(lblPauseTimeStart, 1, 0);
            tlpBreakTime.Controls.Add(lblPauseTimeEnd, 1, 1);
            tlpBreakTime.Dock = DockStyle.Fill;
            tlpBreakTime.Location = new Point(10, 23);
            tlpBreakTime.Name = "tlpBreakTime";
            tlpBreakTime.RowCount = 2;
            tlpBreakTime.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBreakTime.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBreakTime.Size = new Size(766, 106);
            tlpBreakTime.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(3, 3);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(530, 47);
            label3.TabIndex = 0;
            label3.Text = "Break Start:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(3, 56);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(530, 47);
            label4.TabIndex = 1;
            label4.Text = "Break Stop:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPauseTimeStart
            // 
            lblPauseTimeStart.AutoSize = true;
            lblPauseTimeStart.BackColor = Color.LightGreen;
            lblPauseTimeStart.BorderStyle = BorderStyle.Fixed3D;
            lblPauseTimeStart.Dock = DockStyle.Fill;
            lblPauseTimeStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPauseTimeStart.Location = new Point(539, 3);
            lblPauseTimeStart.Margin = new Padding(3);
            lblPauseTimeStart.Name = "lblPauseTimeStart";
            lblPauseTimeStart.Size = new Size(224, 47);
            lblPauseTimeStart.TabIndex = 2;
            lblPauseTimeStart.Text = "00:00:00";
            lblPauseTimeStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPauseTimeEnd
            // 
            lblPauseTimeEnd.AutoSize = true;
            lblPauseTimeEnd.BackColor = Color.LimeGreen;
            lblPauseTimeEnd.BorderStyle = BorderStyle.Fixed3D;
            lblPauseTimeEnd.Dock = DockStyle.Fill;
            lblPauseTimeEnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPauseTimeEnd.Location = new Point(539, 56);
            lblPauseTimeEnd.Margin = new Padding(3);
            lblPauseTimeEnd.Name = "lblPauseTimeEnd";
            lblPauseTimeEnd.Size = new Size(224, 47);
            lblPauseTimeEnd.TabIndex = 3;
            lblPauseTimeEnd.Text = "00:00:00";
            lblPauseTimeEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpFooter
            // 
            tlpFooter.ColumnCount = 2;
            tlpGeneral.SetColumnSpan(tlpFooter, 2);
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFooter.Controls.Add(btnTakeABreak, 0, 0);
            tlpFooter.Controls.Add(lblStatus, 1, 0);
            tlpFooter.Controls.Add(btnStartToWork, 0, 1);
            tlpFooter.Dock = DockStyle.Fill;
            tlpFooter.Location = new Point(8, 325);
            tlpFooter.Name = "tlpFooter";
            tlpFooter.RowCount = 2;
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFooter.Size = new Size(786, 135);
            tlpFooter.TabIndex = 2;
            // 
            // btnTakeABreak
            // 
            btnTakeABreak.BackColor = Color.LightBlue;
            btnTakeABreak.Dock = DockStyle.Fill;
            btnTakeABreak.FlatStyle = FlatStyle.Flat;
            btnTakeABreak.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakeABreak.Location = new Point(0, 7);
            btnTakeABreak.Margin = new Padding(0, 7, 7, 7);
            btnTakeABreak.Name = "btnTakeABreak";
            btnTakeABreak.Size = new Size(386, 53);
            btnTakeABreak.TabIndex = 0;
            btnTakeABreak.Text = "Take a break";
            btnTakeABreak.UseVisualStyleBackColor = false;
            btnTakeABreak.Click += BtnTakeABreak_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblStatus.Location = new Point(396, 3);
            lblStatus.Margin = new Padding(3, 3, 0, 3);
            lblStatus.Name = "lblStatus";
            tlpFooter.SetRowSpan(lblStatus, 2);
            lblStatus.Size = new Size(390, 129);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += LblStatus_Click;
            // 
            // btnStartToWork
            // 
            btnStartToWork.BackColor = Color.LightBlue;
            btnStartToWork.Dock = DockStyle.Fill;
            btnStartToWork.FlatStyle = FlatStyle.Flat;
            btnStartToWork.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartToWork.Location = new Point(0, 74);
            btnStartToWork.Margin = new Padding(0, 7, 7, 7);
            btnStartToWork.Name = "btnStartToWork";
            btnStartToWork.Size = new Size(386, 54);
            btnStartToWork.TabIndex = 2;
            btnStartToWork.Text = "Start to Work";
            btnStartToWork.UseVisualStyleBackColor = false;
            btnStartToWork.Click += BtnStartToWork_Click;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Fill;
            progressBar.Location = new Point(8, 281);
            progressBar.Margin = new Padding(3, 5, 10, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(541, 36);
            progressBar.TabIndex = 3;
            // 
            // timer1s
            // 
            timer1s.Interval = 1000;
            timer1s.Tick += Timer1Seconds_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 463);
            Controls.Add(tlpGeneral);
            Name = "MainForm";
            ShowIcon = false;
            Text = "PC Time Calculator";
            tlpGeneral.ResumeLayout(false);
            tlpGeneral.PerformLayout();
            groupBoxWorkTime.ResumeLayout(false);
            tlpWorkTime.ResumeLayout(false);
            tlpWorkTime.PerformLayout();
            groupBoxBreakTime.ResumeLayout(false);
            tlpBreakTime.ResumeLayout(false);
            tlpBreakTime.PerformLayout();
            tlpFooter.ResumeLayout(false);
            tlpFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpGeneral;
        private GroupBox groupBoxWorkTime;
        private TableLayoutPanel tlpWorkTime;
        private GroupBox groupBoxBreakTime;
        private TableLayoutPanel tlpBreakTime;
        private Label label1;
        private Label label2;
        private Label lblWorkTimeStart;
        private Label lblWorkTimeEnd;
        private Label label3;
        private Label label4;
        private Label lblPauseTimeStart;
        private Label lblPauseTimeEnd;
        private TableLayoutPanel tlpFooter;
        private Button btnTakeABreak;
        private Label lblStatus;
        private Button btnStartToWork;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1s;
        private Label lblTimeRemaining;
    }
}