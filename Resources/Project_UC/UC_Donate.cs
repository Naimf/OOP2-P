using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__Project.Resources.Project_UC
{
    public partial class UC_Donate : UserControl
    {
        private readonly string connectionString = @"Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True";

        public UC_Donate()
        {
            InitializeComponent();
        }

        private void Login(string userId, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT UserId FROM RegistrationTbl WHERE UserId = @UserId AND password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int loggedInUserId = Convert.ToInt32(result);
                        InsertDonation();
                        MessageBox.Show("Thanks For your Contribution ");
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertDonation()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (D_U_id.Text != "" && D_pass.Text != "" && D_M_N.Text != "" && D_Am.Text != "" && transId.Text != "")
                    {
                        string query = "INSERT INTO Donation (UserId, Ammount, MobileNO, TransId) VALUES (@UserId, @Ammount, @MobileNO, @TransId)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UserId", D_U_id.Text);
                        command.Parameters.AddWithValue("@Ammount", D_Am.Text);
                        command.Parameters.AddWithValue("@MobileNO", D_M_N.Text);
                        command.Parameters.AddWithValue("@TransId", transId.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Donation Successful !");
                        D_M_N.Text = "";
                        D_Am.Text = "";
                        D_pass.Text = "";
                        D_U_id.Text = "";
                        transId.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Proc_button_Click(object sender, EventArgs e)
        {
            string userId = D_U_id.Text;
            string password = D_pass.Text;
            Login(userId, password);
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            D_M_N.Text = "";
            D_Am.Text = "";
            D_pass.Text = "";
            D_U_id.Text = "";
            transId.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

