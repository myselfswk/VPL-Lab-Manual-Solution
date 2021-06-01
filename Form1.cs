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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExOne_Click(object sender, EventArgs e)
        {
            ExOne exOne = new ExOne();
            exOne.Show();
        }

        private void btnExTwo_Click(object sender, EventArgs e)
        {
            ExTwo exTwo = new ExTwo();
            exTwo.Show();
        }

        private void btnExThree_Click(object sender, EventArgs e)
        {
            ExThree exThree = new ExThree();
            exThree.Show();
        }

        private void btnExFour_Click(object sender, EventArgs e)
        {
            ExFour exFour = new ExFour();
            exFour.Show();
        }
    }
}
