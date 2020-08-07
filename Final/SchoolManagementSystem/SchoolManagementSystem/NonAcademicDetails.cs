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
    public partial class NonAcademicDetails : Form
    {
        public NonAcademicDetails()
        {
            InitializeComponent();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("please Enter Index Number");

                }
                else
                {

                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    


                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SMS\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    string str = "SELECT *  FROM NonAcademic WHERE nac_id='" + txtID.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    //cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    label4.Text = dr["full_name"].ToString();
                    label13.Text = dr["initial"].ToString();
                    label14.Text = dr["dob"].ToString();
                    label15.Text = dr["gender"].ToString();
                    label16.Text = dr["address"].ToString();
                    label17.Text = dr["mobile"].ToString();
                    label18.Text = dr["email"].ToString();
                    label19.Text = dr["job"].ToString();
                    label20.Text = dr["doe"].ToString();

                    
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
