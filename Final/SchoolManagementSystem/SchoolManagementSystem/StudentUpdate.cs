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

namespace SchoolManagementSystem
{
    public partial class StudentUpdate : Form
    {
        public StudentUpdate()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SMS\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIndex.Text == "")
                {
                    MessageBox.Show("Please Enter Index Number");
                }
                else
                {
                    con.Open();
                    string str = "SELECT * FROM Student WHERE st_id='" + txtIndex.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();

                    txtFullName.Text = dr["full_name"].ToString();
                    txtNameWithInitial.Text = dr["initial"].ToString();
                    dateTimePicker1.Text = dr["dob"].ToString();
                    if (dr["gender"].ToString() == "Male")
                    {
                        radMale.Checked = true;
                    }
                    else
                    {
                        radFemale.Checked = true;
                    }
                    txtAddress.Text = dr["address"].ToString();
                    txtMobile.Text = dr["mobile"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtParent.Text = dr["parent_name"].ToString();
                    txtParentMobile.Text = dr["parent_mobile"].ToString();

                    con.Close();
                }
            }

            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";
                con.Open();
                if (radFemale.Checked)
                {
                    gender = "Female";
                }
                if (radMale.Checked)
                {
                    gender = "Male";
                }
                string str = "UPDATE Student SET full_name='" + txtFullName.Text + "',initial='" + txtNameWithInitial.Text + "',dob='" + dateTimePicker1.Text + "',gender='" + gender + "',address='" + txtAddress.Text + "',mobile='" + txtMobile.Text + "',email='" + txtEmail.Text + "',parent_name='" + txtParent.Text + "',parent_mobile='" + txtParentMobile.Text + "' WHERE st_id='" + txtIndex.Text + "' ";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Update Success");
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtFullName.Clear();
            txtIndex.Clear();
            txtMobile.Clear();
            txtNameWithInitial.Clear();
            txtParent.Clear();
            txtParentMobile.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
