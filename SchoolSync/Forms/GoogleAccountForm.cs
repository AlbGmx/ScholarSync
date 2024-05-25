using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSync.Forms
{
    public partial class GoogleAccountForm : Form
    {
        public GoogleAccountForm()
        {
            InitializeComponent();
        }

        private void GoogleAccountForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
