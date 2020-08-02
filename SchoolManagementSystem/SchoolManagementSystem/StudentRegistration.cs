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
using System.IO;

namespace SchoolManagementSystem
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtNameWithInitial.Text == "" || txtAddress.Text == "" || dateTimePicker1.Text == "" || txtEmail.Text == "" || txtMobile.Text == "" || txtParent.Text == "" || txtParentMobile.Text == "")
                {
                    MessageBox.Show("Please Fill All Details");
                }
                else
                {
                    //dp
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imgArr = new byte[ms.Length];
                    ms.Read(imgArr, 0, imgArr.Length);


                    string gender = "";
                    if (radMale.Checked)
                    {
                        gender = "Male";
                    }
                    if (radFemale.Checked)
                    {
                        gender = "Female";
                    }

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SMS\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    string str = "INSERT INTO Student(full_name,initial,dob,gender,address,mobile,email,parent_name,parent_mobile,dp) VALUES('" + txtFullName.Text + "','" + txtNameWithInitial.Text + "','" + dateTimePicker1.Text + "','" + gender + "','" + txtAddress.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + txtParent.Text + "','" + txtParentMobile.Text + "','"+imgArr+"')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    string str1 = "SELECT TOP(1) st_id FROM Student ORDER BY 1 DESC";
                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader read = cmd1.ExecuteReader();
                    read.Read();
                    string id = read["st_id"].ToString();

                    MessageBox.Show("" + txtNameWithInitial.Text + "'s Data Added " + "Your Index number is " + id);
                    read.Close();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files(*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fd.FileName);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtFullName.Clear();
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
    }
}
