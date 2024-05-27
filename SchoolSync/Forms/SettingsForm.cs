namespace SchoolSync.Forms
{
    public partial class SettingsForm : Form
    {
        public int? FromDate { get; set; }
        public int? UntilDate { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void UpdateDaysTextboxes()
        {
            tBoxFromDate.Text = FromDate.ToString();
            tBoxUntilDate.Text = UntilDate.ToString();
        }

        public void ReceiveData(int? fromDate, int? untilDate)
        {
            FromDate = fromDate ?? 0;
            UntilDate = untilDate ?? 0;
            UpdateDaysTextboxes();
        }

        public int[] GetFormData()
        {
            int[] data = new int[] { FromDate ?? 0, UntilDate ?? 0 };
            return data;
        }

        private void SettingsForm_Load(object? sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) || textBox.Text.Length >= 3)
            {
                e.Handled = true;
            }
        }

        private void DateTimePickerFromDate_ValueChanged(object? sender, EventArgs e)
        {
            tBoxFromDate.Text = GetDifferenceInDays(dtpFromDate.Value, DateTime.Today).ToString();
        }

        private void DateTimePickerUntilDate_ValueChanged(object? sender, EventArgs e)
        {
            tBoxUntilDate.Text = GetDifferenceInDays(DateTime.Today, dtpUntilDate.Value).ToString();
        }

        private static int GetDifferenceInDays(DateTime? fromDate, DateTime? untilDate)
        {
            if (fromDate == null || untilDate == null || fromDate == untilDate)
            {
                return 0;
            }

            return (untilDate.Value - fromDate.Value).Days;
        }

        private void TextBoxFromDate_TextChanged(object? sender, EventArgs e)
        {
            if (int.TryParse(tBoxFromDate.Text, out int daysDifference))
            {
                dtpFromDate.Value = DateTime.Today.AddDays(-daysDifference);
            }
        }

        private void TextBoxUntilDate_TextChanged(object? sender, EventArgs e)
        {
            if (int.TryParse(tBoxUntilDate.Text, out int daysDifference))
            {
                dtpUntilDate.Value = DateTime.Today.AddDays(daysDifference);
            }
        }

        private void SetControl_Click(object sender, EventArgs e)
        {
            FromDate = int.TryParse(tBoxFromDate.Text, out int fromDate) ? fromDate : 0;
            UntilDate = int.TryParse(tBoxUntilDate.Text, out int untilDate) ? untilDate : 0;
        }
    }
}
