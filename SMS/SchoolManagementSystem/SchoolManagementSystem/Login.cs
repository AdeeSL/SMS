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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            passwordHashing pass = new passwordHashing();
            
            try
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter User Name and Password");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SMS\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();

                    string str = "SELECT ac_id FROM Academic WHERE user_name='" + txtUserName.Text + "' and password='" + pass.encodePassword(txtPassword.Text) + "' UNION SELECT nac_id FROM NonAcademic WHERE user_name='" + txtUserName.Text + "' and password='" + pass.encodePassword(txtPassword.Text) + "' ";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Home h1 = new Home();
                        h1.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Invalide User Name or Password");
                    }
                }
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
