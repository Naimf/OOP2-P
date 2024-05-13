using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace C__Project.Resources.Project_UC
{
    public partial class UC_NewAdmin : UserControl
    {
        public UC_NewAdmin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-694JMRN;Initial Catalog=LoginDb;Integrated Security=True;");
        int check(string email)
        {
            connection.Open();
            string query = "select count (*) from Admin_login where email = '" + Admin_u_nameTxt + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }
        private void Admin_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Admin_u_nameTxt.Text!= "'" && admin_passTxt.Text!="'" && con_admin_pass_txt.Text!= "'") 
                {


                    if (admin_passTxt.Text == con_admin_pass_txt.Text)
                    {
                        int v = check( admin_passTxt .Text);
                        if (v != 1)
                        {
                            connection.Open ();
                            SqlCommand command = new SqlCommand("INSERT INTO Admin_login (email , password ) VALUES (@email ,@password )", connection);
                            command.Parameters.AddWithValue("@email", Admin_u_nameTxt.Text);
                            command.Parameters.AddWithValue("@password", admin_passTxt.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Registration Successful !");
                            admin_passTxt.Text = "";
                            Admin_u_nameTxt.Text = "";
                            con_admin_pass_txt .Text = "";



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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void clear()
        {
            Admin_u_nameTxt.Clear();
            admin_passTxt.Clear();
            con_admin_pass_txt.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            admin_passTxt.Clear ();
            Admin_u_nameTxt.Clear ();
            con_admin_pass_txt .Clear ();
        }

        private void UC_NewAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
