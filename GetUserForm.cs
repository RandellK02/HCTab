using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCTab
{
    public partial class GetUserForm : Form
    {
        public GetUserForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
        }

        private void GetUserForm_Load(object sender, EventArgs e)
        {
            // Load AD emails for autofill
        }
    }
}