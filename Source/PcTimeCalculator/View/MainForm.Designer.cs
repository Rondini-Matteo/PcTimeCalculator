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
            this.components = new System.ComponentModel.Container();
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxWorkTime = new System.Windows.Forms.GroupBox();
            this.tlpWorkTime = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWorkTimeStart = new System.Windows.Forms.Label();
            this.lblWorkTimeEnd = new System.Windows.Forms.Label();
            this.groupBoxBreakTime = new System.Windows.Forms.GroupBox();
            this.tlpBreakTime = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPauseTimeStart = new System.Windows.Forms.Label();
            this.lblPauseTimeEnd = new System.Windows.Forms.Label();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnTakeABreak = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStartToWork = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.tlpGeneral.SuspendLayout();
            this.groupBoxWorkTime.SuspendLayout();
            this.tlpWorkTime.SuspendLayout();
            this.groupBoxBreakTime.SuspendLayout();
            this.tlpBreakTime.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.ColumnCount = 1;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.Controls.Add(this.groupBoxWorkTime, 0, 0);
            this.tlpGeneral.Controls.Add(this.groupBoxBreakTime, 0, 1);
            this.tlpGeneral.Controls.Add(this.tlpFooter, 0, 3);
            this.tlpGeneral.Controls.Add(this.progressBar, 0, 2);
            this.tlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tlpGeneral.RowCount = 4;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpGeneral.Size = new System.Drawing.Size(802, 463);
            this.tlpGeneral.TabIndex = 0;
            // 
            // groupBoxWorkTime
            // 
            this.groupBoxWorkTime.Controls.Add(this.tlpWorkTime);
            this.groupBoxWorkTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWorkTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxWorkTime.Location = new System.Drawing.Point(8, 3);
            this.groupBoxWorkTime.Name = "groupBoxWorkTime";
            this.groupBoxWorkTime.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBoxWorkTime.Size = new System.Drawing.Size(786, 132);
            this.groupBoxWorkTime.TabIndex = 0;
            this.groupBoxWorkTime.TabStop = false;
            this.groupBoxWorkTime.Text = "Work Time:";
            // 
            // tlpWorkTime
            // 
            this.tlpWorkTime.ColumnCount = 2;
            this.tlpWorkTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpWorkTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpWorkTime.Controls.Add(this.label1, 0, 0);
            this.tlpWorkTime.Controls.Add(this.label2, 0, 1);
            this.tlpWorkTime.Controls.Add(this.lblWorkTimeStart, 1, 0);
            this.tlpWorkTime.Controls.Add(this.lblWorkTimeEnd, 1, 1);
            this.tlpWorkTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkTime.Location = new System.Drawing.Point(10, 23);
            this.tlpWorkTime.Name = "tlpWorkTime";
            this.tlpWorkTime.RowCount = 2;
            this.tlpWorkTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWorkTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWorkTime.Size = new System.Drawing.Size(766, 106);
            this.tlpWorkTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Time Start:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Work Time Stop:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkTimeStart
            // 
            this.lblWorkTimeStart.AutoSize = true;
            this.lblWorkTimeStart.BackColor = System.Drawing.Color.Coral;
            this.lblWorkTimeStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWorkTimeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkTimeStart.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWorkTimeStart.Location = new System.Drawing.Point(539, 3);
            this.lblWorkTimeStart.Margin = new System.Windows.Forms.Padding(3);
            this.lblWorkTimeStart.Name = "lblWorkTimeStart";
            this.lblWorkTimeStart.Size = new System.Drawing.Size(224, 47);
            this.lblWorkTimeStart.TabIndex = 2;
            this.lblWorkTimeStart.Text = "00:00:00";
            this.lblWorkTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkTimeEnd
            // 
            this.lblWorkTimeEnd.AutoSize = true;
            this.lblWorkTimeEnd.BackColor = System.Drawing.Color.OrangeRed;
            this.lblWorkTimeEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWorkTimeEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkTimeEnd.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWorkTimeEnd.Location = new System.Drawing.Point(539, 56);
            this.lblWorkTimeEnd.Margin = new System.Windows.Forms.Padding(3);
            this.lblWorkTimeEnd.Name = "lblWorkTimeEnd";
            this.lblWorkTimeEnd.Size = new System.Drawing.Size(224, 47);
            this.lblWorkTimeEnd.TabIndex = 3;
            this.lblWorkTimeEnd.Text = "00:00:00";
            this.lblWorkTimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxBreakTime
            // 
            this.groupBoxBreakTime.Controls.Add(this.tlpBreakTime);
            this.groupBoxBreakTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBreakTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBreakTime.Location = new System.Drawing.Point(8, 141);
            this.groupBoxBreakTime.Name = "groupBoxBreakTime";
            this.groupBoxBreakTime.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBoxBreakTime.Size = new System.Drawing.Size(786, 132);
            this.groupBoxBreakTime.TabIndex = 1;
            this.groupBoxBreakTime.TabStop = false;
            this.groupBoxBreakTime.Text = "Break:";
            // 
            // tlpBreakTime
            // 
            this.tlpBreakTime.ColumnCount = 2;
            this.tlpBreakTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpBreakTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBreakTime.Controls.Add(this.label3, 0, 0);
            this.tlpBreakTime.Controls.Add(this.label4, 0, 1);
            this.tlpBreakTime.Controls.Add(this.lblPauseTimeStart, 1, 0);
            this.tlpBreakTime.Controls.Add(this.lblPauseTimeEnd, 1, 1);
            this.tlpBreakTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBreakTime.Location = new System.Drawing.Point(10, 23);
            this.tlpBreakTime.Name = "tlpBreakTime";
            this.tlpBreakTime.RowCount = 2;
            this.tlpBreakTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBreakTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBreakTime.Size = new System.Drawing.Size(766, 106);
            this.tlpBreakTime.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Break Start:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(530, 47);
            this.label4.TabIndex = 1;
            this.label4.Text = "Break Stop:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPauseTimeStart
            // 
            this.lblPauseTimeStart.AutoSize = true;
            this.lblPauseTimeStart.BackColor = System.Drawing.Color.LightGreen;
            this.lblPauseTimeStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPauseTimeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPauseTimeStart.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPauseTimeStart.Location = new System.Drawing.Point(539, 3);
            this.lblPauseTimeStart.Margin = new System.Windows.Forms.Padding(3);
            this.lblPauseTimeStart.Name = "lblPauseTimeStart";
            this.lblPauseTimeStart.Size = new System.Drawing.Size(224, 47);
            this.lblPauseTimeStart.TabIndex = 2;
            this.lblPauseTimeStart.Text = "00:00:00";
            this.lblPauseTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPauseTimeEnd
            // 
            this.lblPauseTimeEnd.AutoSize = true;
            this.lblPauseTimeEnd.BackColor = System.Drawing.Color.LimeGreen;
            this.lblPauseTimeEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPauseTimeEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPauseTimeEnd.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPauseTimeEnd.Location = new System.Drawing.Point(539, 56);
            this.lblPauseTimeEnd.Margin = new System.Windows.Forms.Padding(3);
            this.lblPauseTimeEnd.Name = "lblPauseTimeEnd";
            this.lblPauseTimeEnd.Size = new System.Drawing.Size(224, 47);
            this.lblPauseTimeEnd.TabIndex = 3;
            this.lblPauseTimeEnd.Text = "00:00:00";
            this.lblPauseTimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 2;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.Controls.Add(this.btnTakeABreak, 0, 0);
            this.tlpFooter.Controls.Add(this.lblStatus, 1, 0);
            this.tlpFooter.Controls.Add(this.btnStartToWork, 0, 1);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(8, 325);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 2;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.Size = new System.Drawing.Size(786, 135);
            this.tlpFooter.TabIndex = 2;
            // 
            // btnTakeABreak
            // 
            this.btnTakeABreak.BackColor = System.Drawing.Color.LightBlue;
            this.btnTakeABreak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTakeABreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeABreak.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakeABreak.Location = new System.Drawing.Point(7, 7);
            this.btnTakeABreak.Margin = new System.Windows.Forms.Padding(7);
            this.btnTakeABreak.Name = "btnTakeABreak";
            this.btnTakeABreak.Size = new System.Drawing.Size(379, 53);
            this.btnTakeABreak.TabIndex = 0;
            this.btnTakeABreak.Text = "Take a break";
            this.btnTakeABreak.UseVisualStyleBackColor = false;
            this.btnTakeABreak.Click += new System.EventHandler(this.BtnTakeABreak_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(396, 3);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblStatus.Name = "lblStatus";
            this.tlpFooter.SetRowSpan(this.lblStatus, 2);
            this.lblStatus.Size = new System.Drawing.Size(387, 129);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartToWork
            // 
            this.btnStartToWork.BackColor = System.Drawing.Color.LightBlue;
            this.btnStartToWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartToWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartToWork.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartToWork.Location = new System.Drawing.Point(7, 74);
            this.btnStartToWork.Margin = new System.Windows.Forms.Padding(7);
            this.btnStartToWork.Name = "btnStartToWork";
            this.btnStartToWork.Size = new System.Drawing.Size(379, 54);
            this.btnStartToWork.TabIndex = 2;
            this.btnStartToWork.Text = "Start to Work";
            this.btnStartToWork.UseVisualStyleBackColor = false;
            this.btnStartToWork.Click += new System.EventHandler(this.BtnStartToWork_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(15, 281);
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(772, 36);
            this.progressBar.TabIndex = 3;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 1000;
            this.timerProgressBar.Tick += new System.EventHandler(this.TimerProgressBar_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 463);
            this.Controls.Add(this.tlpGeneral);
            this.Name = "MainForm";
            this.Text = "PC Time Calculator";
            this.tlpGeneral.ResumeLayout(false);
            this.groupBoxWorkTime.ResumeLayout(false);
            this.tlpWorkTime.ResumeLayout(false);
            this.tlpWorkTime.PerformLayout();
            this.groupBoxBreakTime.ResumeLayout(false);
            this.tlpBreakTime.ResumeLayout(false);
            this.tlpBreakTime.PerformLayout();
            this.tlpFooter.ResumeLayout(false);
            this.tlpFooter.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Timer timerProgressBar;
    }
}