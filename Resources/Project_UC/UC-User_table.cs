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
    public partial class UC_User_table : UserControl
    {
        public UC_User_table()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True");
        void BindData()
        {

            try
            {
                using (SqlCommand command = new SqlCommand("select * from RegistrationTbl", connection))
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
        private void UC_User_table_Load(object sender, EventArgs e)
        {

        }








        private void DeleteBtn_Click(object sender, EventArgs e)
        {


            
            try
            {

                if (ID_box.Text != "")
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete RegistrationTbl where UserId = '" + int.Parse(ID_box.Text) + " ' ", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("successfully Deleted");
                    BindData();
                    ID_box.Clear();
                }
                else
                {
                    MessageBox.Show(" ID please");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " );
            }

        }

        private void showallBtn_Click(object sender, EventArgs e)
        {
           // clear();
            BindData();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from RegistrationTbl where UserId = '" + int.Parse(ID_box.Text) + "'", connection);
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
                //clear();
            }
        }
        
    }
}
