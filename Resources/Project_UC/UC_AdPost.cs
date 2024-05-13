using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__Project.Resources.Project_UC
{
    public partial class UC_AdPost : UserControl
    {
        public UC_AdPost()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True;");

        private int GetLoggedInUserId()
        {
            return LoginForm.GetLoggedInUserId(); // Use the full path
        }
        void clear()
        {
            title_textbox.Clear();
            areaBox.Items.Clear();
            location_textbox.Clear();
            price_textbox.Clear();
            categoryBox.Items.Clear();
            contactNumberBox.Clear();
            
        }


        public int loggedInUserId;

        public static class LoginForm  
        {
            public static int loggedInUserId;  

            public static void SetLoggedInUserId(int userId)  
            {
                loggedInUserId = userId;
            }

            public static int GetLoggedInUserId()  
            {
                return loggedInUserId;
            }
        }
        public void SetLoggedInUserId(int userId)
        {
            loggedInUserId = userId;
        }



      

        private void browseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Bitmap tempBitmap = new Bitmap(openFileDialog.FileName);


                    if (IsValidImage(tempBitmap))
                    {

                        pictureBoxProperty.Image = tempBitmap;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid image file.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }


            bool IsValidImage(Bitmap bitmap)
            {

                return bitmap != null && (bitmap.RawFormat.Guid == ImageFormat.Bmp.Guid ||
                                           bitmap.RawFormat.Guid == ImageFormat.Png.Guid ||
                                           bitmap.RawFormat.Guid == ImageFormat.Jpeg.Guid ||
                                           bitmap.RawFormat.Guid == ImageFormat.Gif.Guid);
            }

        }

       

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }



            string u__Id;
            u__Id = U_id.Text;

            try
            {
                string  querry = "SELECT * FROM RegistrationTbl WHERE UserId = '" + U_id.Text + "'" ;
                SqlDataAdapter sda = new SqlDataAdapter(querry, connection);
                DataTable dtbable = new DataTable();
                sda.Fill(dtbable);
                if (dtbable.Rows.Count > 0)
                {

                    if (title_textbox.Text != "" && location_textbox.Text != "" && price_textbox.Text != "" && description_textbox.Text != "" && areaBox.Text != "" && categoryBox.Text != "" && pictureBoxProperty.Text != null && contactNumberBox != null && U_id.Text != null)
                    {

                        decimal price;
                        if (!decimal.TryParse(price_textbox.Text, out price))
                        {
                            MessageBox.Show("Please enter a valid price.");
                            return;
                        }

                        // connection.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO Property (UserId, Title, Area, Location, Price, Description, Photo, Category, Contact_Number) VALUES (@UserId, @Title, @Area, @Location, @Price, @Description, @Photo, @Category, @Contact_Number)", connection);
                        command.Parameters.AddWithValue("@UserId", U_id.Text);
                        command.Parameters.AddWithValue("@Title", title_textbox.Text);
                        command.Parameters.AddWithValue("@Area", areaBox.Text);
                        command.Parameters.AddWithValue("@Location", location_textbox.Text);
                        command.Parameters.AddWithValue("@Price", price_textbox.Text);
                        command.Parameters.AddWithValue("@Category", categoryBox.Text);
                        command.Parameters.AddWithValue("@Contact_Number", contactNumberBox.Text);
                        command.Parameters.AddWithValue("@Description", description_textbox.Text);
                        byte[] imageData;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBoxProperty.Image.Save(ms, pictureBoxProperty.Image.RawFormat);
                            imageData = ms.ToArray();
                        }
                        command.Parameters.AddWithValue("@Photo", imageData);
                        command.ExecuteNonQuery();
                        

                        MessageBox.Show("Added Successfully");
                        connection.Close();
                        
                        U_id.Text = "";
                        title_textbox.Text = "";
                        areaBox.Text = "";
                        location_textbox.Text = "";
                        price_textbox.Text = "";
                        categoryBox.Text= "";
                        contactNumberBox.Text = "";
                        description_textbox.Text = "";
                        pictureBoxProperty.Image = null;


                        
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fill all the options");
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("invalid User id");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
            }
        }

        private void UC_AdPost_Load(object sender, EventArgs e)
        {

        }
    } }
       
