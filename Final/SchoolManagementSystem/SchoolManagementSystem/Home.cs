using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentRegistration st1 = new StudentRegistration();
            st1.Show();
            this.Hide();
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            AcademicRegistration ac1 = new AcademicRegistration();
            ac1.Show();
            this.Hide();
        }

        private void btnNonAcademic_Click(object sender, EventArgs e)
        {
            NonAcademicRegistration nac1 = new NonAcademicRegistration();
            nac1.Show();
            this.Hide();
        }

        private void btnChangeStudent_Click(object sender, EventArgs e)
        {
            StudentUpdate stu = new StudentUpdate();
            stu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteStudent std = new DeleteStudent();
            std.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteAcademic acd = new DeleteAcademic();
            acd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteNonAcademic nacd = new DeleteNonAcademic();
            nacd.Show();
            this.Hide();
        }

        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            StudentDetails stde = new StudentDetails();
            stde.Show();
            this.Hide();
        }

        private void btnAcademicDetails_Click(object sender, EventArgs e)
        {
            AcademicDetails acde = new AcademicDetails();
            acde.Show();
            this.Hide();
        }

        private void btnnonAcademicDetails_Click(object sender, EventArgs e)
        {
            NonAcademicDetails nacde = new NonAcademicDetails();
            nacde.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
