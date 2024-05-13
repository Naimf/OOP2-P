using C__Project.Resources.Project_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();

        }
        private void GenerateDynamicUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
        }
        

        private void NewAdminBtn_Click(object sender, EventArgs e)
        {
            UC_NewAdmin uc = new UC_NewAdmin ();
            GenerateDynamicUserControl(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();

        }


        private void lgtBtn_Click(object sender, EventArgs e)
        {
            UC_Admin_chng_pass uc = new UC_Admin_chng_pass ();
            GenerateDynamicUserControl (uc);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UC_User_table uc = new UC_User_table ();
            GenerateDynamicUserControl(uc);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UC_Donation_Table uc = new UC_Donation_Table ();
            GenerateDynamicUserControl(uc);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UC_Admin_property uc = new UC_Admin_property ();
            GenerateDynamicUserControl(uc);
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
