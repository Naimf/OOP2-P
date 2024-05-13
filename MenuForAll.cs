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
    public partial class MenuForAll : Form
    {
       String u_name, password;

        
        public MenuForAll()
        {
            InitializeComponent();
           

        }
       

        private void panel3Container_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GenerateDynamicUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3Container.Controls.Clear();
            panel3Container.Controls.Add(userControl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuForAll_Load(object sender, EventArgs e)
        {
            

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

           UC_home uc = new UC_home();
            GenerateDynamicUserControl(uc);
        }

        private void WishlistBtn_Click(object sender, EventArgs e)
        {
           UC_wishlist uc = new UC_wishlist();
            GenerateDynamicUserControl(uc);
        }

        private void PostAdBtn_Click(object sender, EventArgs e)
        {
            UC_AdPost uC = new UC_AdPost(); 
            GenerateDynamicUserControl(uC);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DonateUs_Click(object sender, EventArgs e)
        {
          UC_Donate uc = new UC_Donate ();
            GenerateDynamicUserControl(uc);
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
          UC_Profile uc = new UC_Profile();
            GenerateDynamicUserControl (uc);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

                    }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            UC_info uc = new UC_info();
            GenerateDynamicUserControl(uc);
        }

        

       }
}
