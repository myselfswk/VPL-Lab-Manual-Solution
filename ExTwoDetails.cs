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
    public partial class ExTwoDetails : Form
    {
        public ExTwoDetails()
        {
            InitializeComponent();
            lblIDShow.Text = ExTwo.ID.ToString();
            lblNameShow.Text = ExTwo.NameShow.ToString();
            lblGen.Text = ExTwo.Gender.ToString();
            lblEmail.Text = ExTwo.Email.ToString();
            lblNat.Text = ExTwo.Nationality.ToString();
            lblSem.Text = ExTwo.Sem.ToString();
            lblDept.Text = ExTwo.Dept.ToString();
        }

        private void ExTwoDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
