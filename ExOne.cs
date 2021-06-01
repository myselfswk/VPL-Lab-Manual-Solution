using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPL_Lab_Manual_Solution
{
    public partial class ExOne : Form
    {
        public ExOne()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text, "Iqra University");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = txtEmail.Text = txtPass.Text = txtCourse.Text = "";
        }
    }
}
