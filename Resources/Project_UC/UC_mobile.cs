using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project.Resources.Project_UC
{
    public partial class UC_mobile : UserControl
    {
        public UC_mobile()
        {
            InitializeComponent();
        }

        private void Proc_button_Click(object sender, EventArgs e)
        {
            if (MobileNumber.Text != "" && transId.Text != "")
            {
                MessageBox.Show("Payment Successful");
                this.Hide();
                MenuForAll mf = new MenuForAll();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Full your information perfrctly");
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForAll mf
                = new MenuForAll();
            mf.Show();
        }

        private void UC_mobile_Load(object sender, EventArgs e)
        {

        }
    }
}
