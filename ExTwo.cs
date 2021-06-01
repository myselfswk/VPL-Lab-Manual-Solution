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
    public partial class ExTwo : Form
    {
        public static string ID;
        public static string NameShow;
        public static string Gender;
        public static string Email;
        public static string Nationality;
        public static string Sem;
        public static string Dept;
        public ExTwo()
        {
            InitializeComponent();
            ID = txtID.Text;
            NameShow = txtName.Text;
            Gender = txtGen.Text;
            Email = txtEmail.Text;
            Nationality = txtNat.Text;
            Sem = txtSem.Text;
            Dept = txtDept.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ExTwoDetails exTwoDetails = new ExTwoDetails();
            exTwoDetails.Show();
        }
    }
}
