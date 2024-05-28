namespace ScholarSync.Forms
{
    partial class NotificationForm
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
            snoozeLabel = new Button();
            dismissLabel = new Button();
            panel1 = new Panel();
            timeLeftLabel = new Label();
            dueToLabel = new Label();
            pictureBox1 = new PictureBox();
            courseLabel = new Label();
            assignmentLabel = new Label();
            snoozeTimer = new System.Windows.Forms.Timer(components);
            showTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // snoozeLabel
            // 
            snoozeLabel.Location = new Point(132, 90);
            snoozeLabel.Name = "snoozeLabel";
            snoozeLabel.Size = new Size(75, 23);
            snoozeLabel.TabIndex = 0;
            snoozeLabel.Text = "Snooze";
            snoozeLabel.UseVisualStyleBackColor = true;
            snoozeLabel.Click += snoozeLabel_Click;
            // 
            // dismissLabel
            // 
            dismissLabel.Location = new Point(213, 90);
            dismissLabel.Name = "dismissLabel";
            dismissLabel.Size = new Size(75, 23);
            dismissLabel.TabIndex = 1;
            dismissLabel.Text = "Dismiss";
            dismissLabel.UseVisualStyleBackColor = true;
            dismissLabel.Click += dismissLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(205, 232, 229);
            panel1.Controls.Add(timeLeftLabel);
            panel1.Controls.Add(dueToLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(courseLabel);
            panel1.Controls.Add(assignmentLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 80);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // timeLeftLabel
            // 
            timeLeftLabel.AutoSize = true;
            timeLeftLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLeftLabel.Location = new Point(184, 55);
            timeLeftLabel.Name = "timeLeftLabel";
            timeLeftLabel.Size = new Size(104, 17);
            timeLeftLabel.TabIndex = 4;
            timeLeftLabel.Text = "Time Left: 15 hrs";
            // 
            // dueToLabel
            // 
            dueToLabel.AutoSize = true;
            dueToLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueToLabel.Location = new Point(53, 55);
            dueToLabel.Name = "dueToLabel";
            dueToLabel.Size = new Size(91, 17);
            dueToLabel.TabIndex = 3;
            dueToLabel.Text = "Due to: XX/XX";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.assignment;
            pictureBox1.Location = new Point(7, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseLabel.Location = new Point(53, 26);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(59, 21);
            courseLabel.TabIndex = 1;
            courseLabel.Text = "Course";
            // 
            // assignmentLabel
            // 
            assignmentLabel.AutoSize = true;
            assignmentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assignmentLabel.Location = new Point(53, 5);
            assignmentLabel.Name = "assignmentLabel";
            assignmentLabel.Size = new Size(100, 21);
            assignmentLabel.TabIndex = 0;
            assignmentLabel.Text = "Assignment";
            // 
            // snoozeTimer
            // 
            snoozeTimer.Interval = 6000;
            snoozeTimer.Tick += snoozeTimer_Tick;
            // 
            // showTimer
            // 
            showTimer.Enabled = true;
            showTimer.Interval = 5;
            showTimer.Tick += showTimer_Tick;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(77, 134, 156);
            ClientSize = new Size(300, 120);
            Controls.Add(panel1);
            Controls.Add(dismissLabel);
            Controls.Add(snoozeLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationForm";
            Text = "NotificationForm";
            Load += NotificationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            this.ShowInTaskbar = false;
        }

        #endregion

        private Button snoozeLabel;
        private Button dismissLabel;
        private Panel panel1;
        private Label assignmentLabel;
        private PictureBox pictureBox1;
        private Label courseLabel;
        private Label timeLeftLabel;
        private Label dueToLabel;
        private System.Windows.Forms.Timer snoozeTimer;
        private System.Windows.Forms.Timer showTimer;
    }
}