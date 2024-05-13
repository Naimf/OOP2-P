using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project.Resources.Project_UC
{
    public partial class UC_Donation_Table : UserControl
    {
        public UC_Donation_Table()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True");
        void BindData()
        {

            try
            {
                using (SqlCommand command = new SqlCommand("select * from  Donation ", connection))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        DataTable dtbable = new DataTable();
                        sda.Fill(dtbable);
                        dataGridView1.DataSource = dtbable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }



        }
        private void Sh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void UC_Donation_Table_Load(object sender, EventArgs e)
        {

        }
    }
}
