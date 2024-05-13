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
    public partial class UC_home : UserControl
    {
        private DataTable simulatedData;
        public UC_home()
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
                        // dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();

        }





        public void cmbFilter1()
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from Property where Category = '" + comboBox1.Text.ToString() + "'", connection);
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        DataTable dtbable = new DataTable();
                        sda.Fill(dtbable);
                        dataGridView1.DataSource = dtbable;
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
            }
        }


        public void cmbFilter2()
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from Property where Area = '" + comboBox2.Text.ToString() + "'", connection);
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        DataTable dtbable = new DataTable();
                        sda.Fill(dtbable);
                        dataGridView1.DataSource = dtbable;
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
            }
        }
    







        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbFilter1();
            comboBox2.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilter2();
            comboBox1.Text = "";
        }
        private void LoadImageIntoPictureBox(int propertyId)
        {
            /*// SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True");
             try
             {
                // using (SqlConnection conn = new SqlConnection(connection))
                // {
                     connection.Open();
                     string query = "SELECT Photo FROM [dbo].[Property] WHERE PropertyID = @PropertyID";
                     SqlCommand command = new SqlCommand(query, connection);
                     command.Parameters.AddWithValue("@PropertyID", propertyId);

                     using (SqlDataReader reader = command.ExecuteReader())
                     {
                         if (reader.Read())
                         {
                             byte[] imageData = (byte[])reader["Photo"];
                             using (MemoryStream ms = new MemoryStream(imageData))
                             {
                                 HomePictureBox. Image = Image.FromStream(ms);
                             }
                         }
                     }
                // }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error loading image: " + ex.Message);
             }*/


           /* if (e.ColumnIndex == dataGridView1.Columns["Photo"].Index && e.RowIndex >= 0)
            {
                // Get the value of the P_image column in the selected row
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells["Photo"].Value;

                // Check if the cell value is not null and is of type byte[]
                if (cellValue != null && cellValue is byte[])
                {
                    // Convert byte[] to Image
                    byte[] imgData = (byte[])cellValue;
                    Image img;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        img = Image.FromStream(ms);
                    }

                    // Display the image in the PictureBox
                    HomePictureBox.Image = img;
                }
                else
                {
                    // Handle case where the cell value is not a byte array or is null
                    MessageBox.Show("The selected cell does not contain a valid image.");
                }
            }*/
        }
    

    private void UC_home_Load(object sender, EventArgs e)
        {
           
        }

        private void HomePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (e.ColumnIndex == dataGridView1.Columns["Photo"].Index && e.RowIndex >= 0)
            {
                
                byte[] imageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells["Photo"].Value;

               
                if (imageData != null && imageData.Length > 0)
                {
                   
                    Image image;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        image = Image.FromStream(ms);
                    }

                    HomePictureBox.Image = image;
                }
                else
                {
                    
                    MessageBox.Show("No image available.");
                }
            }


        }

        private void HomePictureBox_Click_1(object sender, EventArgs e)
        {

        }

        private void UC_home_Load_1(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

    

