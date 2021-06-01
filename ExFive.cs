using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VPL_Lab_Manual_Solution
{
    public partial class ExFive : Form
    {
        public ExFive()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(local);Initial Catalog=Tutorials;Integrated Security=True");
            cn.Open();
            //bind data in data grid view  
            GetAllEmployeeRecord();

            //disable delete and update button on load  
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void GetAllEmployeeRecord()
        {
            cmd = new SqlCommand("EmployeeCrudOperation", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Employeeid", 0);
            cmd.Parameters.AddWithValue("@EmployeeName", "");
            cmd.Parameters.AddWithValue("@EmployeeSalary", 0);
            cmd.Parameters.AddWithValue("@EmployeeCity", "");
            cmd.Parameters.AddWithValue("@OperationType", "5");
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (txtempcity.Text != string.Empty && txtempname.Text != string.Empty && txtempsalary.Text != string.Empty)
            {
                cmd = new SqlCommand("EmployeeCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Employeeid", 0);
                cmd.Parameters.AddWithValue("@EmployeeName", txtempname.Text);
                cmd.Parameters.AddWithValue("@EmployeeSalary", txtempsalary.Text);
                cmd.Parameters.AddWithValue("@EmployeeCity", txtempcity.Text);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllEmployeeRecord();
                txtempcity.Text = "";
                txtempid.Text = "";
                txtempname.Text = "";
                txtempsalary.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
}
