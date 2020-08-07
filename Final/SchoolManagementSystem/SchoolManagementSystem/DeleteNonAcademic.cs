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
    public partial class DeleteNonAcademic : Form
    {
        public DeleteNonAcademic()
        {
            InitializeComponent();
        }

        private void DeleteNonAcademic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolManagementSystemDataSet2.NonAcademic' table. You can move, or remove it, as needed.
            this.nonAcademicTableAdapter.Fill(this.schoolManagementSystemDataSet2.NonAcademic);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Please Enter Index Number");
                }

                else
                {
                    DialogResult message = MessageBox.Show("Are You Sure", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (message == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SMS\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30")
)
                        {

                            string str = "DELETE  FROM NonAcademic WHERE nac_id='" + txtID.Text + "'";
                            SqlCommand cmd = new SqlCommand(str, con);
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            dataGridView1.DataSource = new BindingSource(dt, null);
                        }

                    }
                    else if (message == DialogResult.No)
                    {
                        txtID.Text = "";
                    }

                }

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\AdeeSL\c#\SMS\SchoolManagementSystem\SchoolManagementSystem\SchoolManagementSystem.mdf;Integrated Security=True;Connect Timeout=30")
)
                {
                    string str = "SELECT * FROM NonAcademic";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null);


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
    }
}
