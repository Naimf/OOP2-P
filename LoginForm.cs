using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True");

        public int loggedInUserId;

        public static class AuthenticationHelper
        {
            public static int GetLoggedInUserId(string userEmail, string userPassword)
            {
                int userId = 0;
                string connectionString = "Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True"; // Replace with your actual connection string

                // Use parameterized query to prevent SQL injection
                string query = "SELECT UserId FROM RegistrationTbl WHERE email = @Email AND password = @Password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", userEmail);
                        command.Parameters.AddWithValue("@Password", userPassword);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }

                return userId;
            }
        }
       public void SetLoggedInUserId(int userId)
        {
            loggedInUserId = userId;
        }
        public int GetLoggedInUserId()
        {
            return GetLoggedInUserId(); 
        }

        

        private void LgBtn_Click(object sender, EventArgs e)
        {
            string email = u_name.Text;
            string user_password = password.Text;
            Login(email, user_password);

        }
        private void Login(string email, string password)
        {
            try
            {
                connection.Open();

                string query = "SELECT UserId FROM RegistrationTbl WHERE email = @Email AND password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int userId = Convert.ToInt32(result);
                    //SetLoggedInUserId(userId);
                    MessageBox.Show($"WElcome Back mate . User ID: {userId}");
                    // Open the main menu form
                    MenuForAll mf = new MenuForAll();
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void admin_loginBtn_Click(object sender, EventArgs e)
        {

            string email, user_password;
            email = u_name.Text;
            user_password = password.Text;
            try
            {
                string querry = "SELECT * FROM Admin_login WHERE email = '" + u_name.Text + "'AND password = '" + password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, connection);
                DataTable dtbable = new DataTable();
                sda.Fill(dtbable);
                if (dtbable.Rows.Count > 0)
                {
                    email = u_name.Text;
                    user_password = password.Text;
                    Admin_Panel ap = new Admin_Panel();
                    ap.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid login details", "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    u_name.Clear();
                    password.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error!");

            }
            finally
            {
                connection.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SignUp_Form form = new SignUp_Form();
            this.Hide();
            form.Show();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void u_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
