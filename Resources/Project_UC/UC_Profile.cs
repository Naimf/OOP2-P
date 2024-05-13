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
    public partial class UC_Profile : UserControl
    {
        public UC_Profile()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True;");

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {


            string username = txtUserId.Text;
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string conNewPassword = conTxtNewPassword.Text;


            try
            {
                string query = "SELECT * FROM RegistrationTbl WHERE UserId = '" + txtUserId.Text + "' AND password = '" + txtCurrentPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbable = new DataTable();
                sda.Fill(dtbable);
                if (dtbable.Rows.Count > 0)
                {

                    if (txtUserId.Text != "" && txtCurrentPassword.Text != "" && txtNewPassword.Text != "" && conTxtNewPassword.Text != "")
                    {
                        string updateQuery = "UPDATE RegistrationTbl SET password = @NewPassword WHERE UserID = @UserId";
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@NewPassword", newPassword);
                            command.Parameters.AddWithValue("@UserId", txtUserId.Text);

                            // Open the connection (if not already open)
                            if (connection.State != ConnectionState.Open)
                            { connection.Open(); }

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password changed successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update password.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Fill all data.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
                {


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        private void CnclBtn_Click(object sender, EventArgs e)
        {

            txtUserId.Text = "";
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            conTxtNewPassword.Text = "";
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
