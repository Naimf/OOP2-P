using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project.Resources.Project_UC
{
    public partial class UC_Admin_property : UserControl
    {
        public UC_Admin_property()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True");
        void BindData()
        {

            try
            {
                using (SqlCommand command = new SqlCommand("select * from  Property ", connection))
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
        private void Admin_Prop_show_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void Admn_del_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (P_id_del.Text != "")
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete Property where PropertyId = '" + int.Parse(P_id_del.Text) + " ' ", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("successfully Deleted");
                    BindData();
                    P_id_del.Clear();
                }
                else
                {
                    MessageBox.Show(" ID please");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
            {
                if (e.RowIndex >= 0  && e.ColumnIndex == dataGridView1.Columns["Photo"].Index)
                {
                    DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    if (selectedCell.Value != null && selectedCell.Value is byte[])
                    {
                        byte[] imgData = (byte[])selectedCell.Value;
                        Image img;
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            img = Image.FromStream(ms);
                        }

                        pictureBox1.Image = img;
                    }
                    else
                    {
                        MessageBox.Show("The selected cell does not contain a valid image.");
                    }
                }
            }

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Admin_property_Load(object sender, EventArgs e)
        {

        }
    }
}
