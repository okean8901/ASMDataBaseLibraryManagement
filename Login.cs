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

namespace ASM_library_management_database
{
    public partial class LoginForm : Form
    {
        SqlConnection connection;
        public LoginForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-NB4LK8U\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsename.Text;
            string password = txbPassword.Text;
            string query = "select * from users where username =@username and u_password =@password";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;

            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["u_role"].ToString();
                if (role.Equals("admin"))
                {
                    MessageBox.Show(this, "Login successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();

                    BookManagement p = new BookManagement(username);
                    p.ShowDialog();
                    this.Dispose();
                }

                else if (role.Equals("user"))
                {
                    MessageBox.Show(this, "Login successfull! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    ViewBook vp = new ViewBook(username);
                    vp.ShowDialog();
                    this.Dispose();
                }
                else
                    label5.Text = "You are not a allowed to access";
            }
            else
            {
                label5.Text = "Wrong username or password";
            }
            connection.Close();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to exit?", " Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }
    }
}
