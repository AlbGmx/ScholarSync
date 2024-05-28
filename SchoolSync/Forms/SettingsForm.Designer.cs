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
            dtpUntilDate = new DateTimePicker();
            lblDateRangeDescription = new Label();
            tBoxUntilDate = new TextBox();
            tBoxFromDate = new TextBox();
            SetControl = new Button();
            SuspendLayout();
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(284, 452);
            dtpFromDate.MaxDate = new DateTime(2024, 5, 25, 0, 0, 0, 0);
            dtpFromDate.MinDate = new DateTime(2021, 8, 29, 23, 11, 22, 629);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(200, 23);
            dtpFromDate.TabIndex = 0;
            dtpFromDate.Value = new DateTime(2024, 5, 25, 0, 0, 0, 0);
            dtpFromDate.ValueChanged += DateTimePickerFromDate_ValueChanged;
            // 
            // dtpUntilDate
            // 
            dtpUntilDate.Location = new Point(730, 452);
            dtpUntilDate.MaxDate = new DateTime(2027, 2, 18, 23, 11, 22, 631);
            dtpUntilDate.MinDate = new DateTime(2024, 5, 25, 0, 0, 0, 0);
            dtpUntilDate.Name = "dtpUntilDate";
            dtpUntilDate.Size = new Size(200, 23);
            dtpUntilDate.TabIndex = 1;
            dtpUntilDate.ValueChanged += DateTimePickerUntilDate_ValueChanged;
            // 
            // lblDateRangeDescription
            // 
            lblDateRangeDescription.AutoSize = true;
            lblDateRangeDescription.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateRangeDescription.Location = new Point(284, 214);
            lblDateRangeDescription.Name = "lblDateRangeDescription";
            lblDateRangeDescription.Size = new Size(723, 86);
            lblDateRangeDescription.TabIndex = 2;
            lblDateRangeDescription.Text = "Ajuste de Rango de dias";
            // 
            // tBoxUntilDate
            // 
            tBoxUntilDate.Location = new Point(936, 452);
            tBoxUntilDate.Name = "tBoxUntilDate";
            tBoxUntilDate.PlaceholderText = "000";
            tBoxUntilDate.Size = new Size(28, 23);
            tBoxUntilDate.TabIndex = 4;
            tBoxUntilDate.TextAlign = HorizontalAlignment.Center;
            tBoxUntilDate.TextChanged += TextBoxUntilDate_TextChanged;
            tBoxUntilDate.KeyPress += TextBox_KeyPress;
            // 
            // tBoxFromDate
            // 
            tBoxFromDate.Location = new Point(490, 452);
            tBoxFromDate.Name = "tBoxFromDate";
            tBoxFromDate.PlaceholderText = "000";
            tBoxFromDate.Size = new Size(28, 23);
            tBoxFromDate.TabIndex = 5;
            tBoxFromDate.TextAlign = HorizontalAlignment.Center;
            tBoxFromDate.TextChanged += TextBoxFromDate_TextChanged;
            tBoxFromDate.KeyPress += TextBox_KeyPress;
            // 
            // SetControl
            // 
            SetControl.AutoSize = true;
            SetControl.Location = new Point(574, 532);
            SetControl.Name = "SetControl";
            SetControl.Size = new Size(110, 25);
            SetControl.TabIndex = 6;
            SetControl.Text = "Establecer Valores";
            SetControl.UseVisualStyleBackColor = true;
            SetControl.Click += SetControl_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 800);
            Controls.Add(SetControl);
            Controls.Add(tBoxFromDate);
            Controls.Add(tBoxUntilDate);
            Controls.Add(lblDateRangeDescription);
            Controls.Add(dtpUntilDate);
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
        private DateTimePicker dtpUntilDate;
        private Label lblDateRangeDescription;
        private TextBox tBoxUntilDate;
        private TextBox tBoxFromDate;
        private Button SetControl;
    }
}