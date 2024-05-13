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

namespace C__Project
{
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True");

        int check(string email)
        {
            connection.Open();
            string query = "select count (*) from RegistrationTbl where email = '" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        static int GenerateRandomUserId()
        {
            // Generate a random number for user ID
            Random rnd = new Random();
            return rnd.Next(1, 1000); // Adjust the range as needed
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (first_name.Text != "" && l_name.Text != "" && gender.Text != "" && email.Text != "" &&
                    password.Text != "" && con_password.Text != "")
                {
                    if (password.Text == con_password.Text)
                    {

                        int userId = GenerateRandomUserId();

                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("SET IDENTITY_INSERT RegistrationTbl ON; " + "INSERT INTO RegistrationTbl ( UserId , f_name, l_name, gender, email, password) VALUES (@UserId, @f_name, @l_name, @gender, @email, @password)", connection);

                            // SqlCommand command = new SqlCommand("INSERT INTO RegistrationTbl (f_name, l_name, gender, email, password) VALUES (@f_name, @l_name, @gender, @email, @password)", connection);
                            command.Parameters.AddWithValue("@f_name", first_name.Text);
                            command.Parameters.AddWithValue("@l_name", l_name.Text);
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Registration Successful !");
                            first_name.Text = "";
                            email.Text = "";
                            l_name.Text = "";
                            gender.Text = "";
                            password.Text = "";
                            con_password.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("You are already Registered");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match .");

                    }
                }
                else
                {
                    MessageBox.Show("Fill the blanks.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
