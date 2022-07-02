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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWorkTimeStart = new System.Windows.Forms.Label();
            this.lblWorkTimeEnd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPauseTimeStart = new System.Windows.Forms.Label();
            this.lblPauseTimeEnd = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTakeABreak = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStartToWork = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Time:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblWorkTimeStart, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblWorkTimeEnd, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 118);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Time Start:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 53);
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
            this.lblWorkTimeStart.Location = new System.Drawing.Point(554, 3);
            this.lblWorkTimeStart.Margin = new System.Windows.Forms.Padding(3);
            this.lblWorkTimeStart.Name = "lblWorkTimeStart";
            this.lblWorkTimeStart.Size = new System.Drawing.Size(231, 53);
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
            this.lblWorkTimeEnd.Location = new System.Drawing.Point(554, 62);
            this.lblWorkTimeEnd.Margin = new System.Windows.Forms.Padding(3);
            this.lblWorkTimeEnd.Name = "lblWorkTimeEnd";
            this.lblWorkTimeEnd.Size = new System.Drawing.Size(231, 53);
            this.lblWorkTimeEnd.TabIndex = 3;
            this.lblWorkTimeEnd.Text = "00:00:00";
            this.lblWorkTimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Break:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPauseTimeStart, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblPauseTimeEnd, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 118);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.label3.Size = new System.Drawing.Size(545, 53);
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
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 53);
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
            this.lblPauseTimeStart.Location = new System.Drawing.Point(554, 3);
            this.lblPauseTimeStart.Margin = new System.Windows.Forms.Padding(3);
            this.lblPauseTimeStart.Name = "lblPauseTimeStart";
            this.lblPauseTimeStart.Size = new System.Drawing.Size(231, 53);
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
            this.lblPauseTimeEnd.Location = new System.Drawing.Point(554, 62);
            this.lblPauseTimeEnd.Margin = new System.Windows.Forms.Padding(3);
            this.lblPauseTimeEnd.Name = "lblPauseTimeEnd";
            this.lblPauseTimeEnd.Size = new System.Drawing.Size(231, 53);
            this.lblPauseTimeEnd.TabIndex = 3;
            this.lblPauseTimeEnd.Text = "00:00:00";
            this.lblPauseTimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnTakeABreak, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblStatus, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnStartToWork, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(794, 144);
            this.tableLayoutPanel4.TabIndex = 2;
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
            this.btnTakeABreak.Size = new System.Drawing.Size(383, 58);
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
            this.lblStatus.Location = new System.Drawing.Point(400, 3);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblStatus.Name = "lblStatus";
            this.tableLayoutPanel4.SetRowSpan(this.lblStatus, 2);
            this.lblStatus.Size = new System.Drawing.Size(391, 138);
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
            this.btnStartToWork.Location = new System.Drawing.Point(7, 79);
            this.btnStartToWork.Margin = new System.Windows.Forms.Padding(7);
            this.btnStartToWork.Name = "btnStartToWork";
            this.btnStartToWork.Size = new System.Drawing.Size(383, 58);
            this.btnStartToWork.TabIndex = 2;
            this.btnStartToWork.Text = "Start to Work";
            this.btnStartToWork.UseVisualStyleBackColor = false;
            this.btnStartToWork.Click += new System.EventHandler(this.BtnStartToWork_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "PC Time Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label lblWorkTimeStart;
        private Label lblWorkTimeEnd;
        private Label label3;
        private Label label4;
        private Label lblPauseTimeStart;
        private Label lblPauseTimeEnd;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnTakeABreak;
        private Label lblStatus;
        private Button btnStartToWork;
    }
}