using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Add the following namespace   
using System.Text.RegularExpressions;

namespace VPL_Lab_Manual_Solution
{
    public partial class ExFour : Form
    {
        public ExFour()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Create string variables that contain the patterns   
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Email address pattern  
            string zipCodePattern = @"^\d{3}\s?\d{3}$";
            string phonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$"; // US Phone number pattern   

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isEmailValid = Regex.IsMatch(txtEmail.Text, emailPattern);
            bool isZipValid = Regex.IsMatch(txtZipCode.Text, zipCodePattern);
            bool isPhoneValid = Regex.IsMatch(txtPhone.Text, phonePattern);

            // Now you can check the result   
            if (!isEmailValid)
            {
                MessageBox.Show("Please enter a valid email");
            }

            if (!isZipValid)
            {
                MessageBox.Show("Please enter a valid zip code");
            }

            if (!isPhoneValid)
            {
                MessageBox.Show("Please enter a valid phone number");
            }
        }
    }
}
