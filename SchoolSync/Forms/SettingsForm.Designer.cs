namespace SchoolSync.Forms
{
    partial class SettingsForm
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
            dtpFromDate = new DateTimePicker();
            dtpUntilDay = new DateTimePicker();
            lblDateRangeDescription = new Label();
            SuspendLayout();
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(284, 452);
            dtpFromDate.MaxDate = new DateTime(2024, 5, 25, 0, 0, 0, 0);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(200, 23);
            dtpFromDate.TabIndex = 0;
            dtpFromDate.Value = new DateTime(2024, 5, 25, 0, 0, 0, 0);
            // 
            // dtpUntilDay
            // 
            dtpUntilDay.Location = new Point(785, 452);
            dtpUntilDay.MinDate = new DateTime(2024, 5, 25, 0, 0, 0, 0);
            dtpUntilDay.Name = "dtpUntilDay";
            dtpUntilDay.Size = new Size(200, 23);
            dtpUntilDay.TabIndex = 1;
            // 
            // lblDateRangeDescription
            // 
            lblDateRangeDescription.AutoSize = true;
            lblDateRangeDescription.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateRangeDescription.Location = new Point(284, 218);
            lblDateRangeDescription.Name = "lblDateRangeDescription";
            lblDateRangeDescription.Size = new Size(701, 86);
            lblDateRangeDescription.TabIndex = 2;
            lblDateRangeDescription.Text = "Ajuse de Rango de dias";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 800);
            Controls.Add(lblDateRangeDescription);
            Controls.Add(dtpUntilDay);
            Controls.Add(dtpFromDate);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1296, 800);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpUntilDay;
        private Label lblDateRangeDescription;
    }
}