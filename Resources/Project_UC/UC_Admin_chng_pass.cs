using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__Project.Resources.Project_UC
{
    public partial class UC_Admin_chng_pass : UserControl
    {
        public UC_Admin_chng_pass()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True;");

        private void Admin_chng_pass_Load(object sender, EventArgs e)
        {

        }

        private void CnclBtn_Click(object sender, EventArgs e)
        {
            txtNewPassword.Clear();
            conTxtNewPassword.Clear();
            txtCurrentPassword.Clear();

        }

        private void Save_Click(object sender, EventArgs e)
        {
           


            string username = txtAdminId.Text;
           string currentPassword =txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text; 
            string conNewPassword = conTxtNewPassword.Text;

           
            try
            {
                string query = "SELECT * FROM Admin_login WHERE Admin_id = '" + txtAdminId.Text + "' AND password = '" + txtCurrentPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbable = new DataTable();
                sda.Fill(dtbable);
                if (dtbable.Rows.Count > 0)
                {

                    if (txtAdminId.Text != "" && txtCurrentPassword.Text != "" && txtNewPassword.Text != "" && conTxtNewPassword.Text != "")
                    {
                        string updateQuery = "UPDATE Admin_login SET password = @NewPassword WHERE Admin_id = @AdminId";
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@NewPassword", newPassword);
                            command.Parameters.AddWithValue("@AdminId", txtAdminId.Text);

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAdminId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void conTxtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
