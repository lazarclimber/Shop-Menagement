using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop__invertory_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordInput.UseSystemPasswordChar = false;
            }
            else
            {
                passwordInput.UseSystemPasswordChar = true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=shopInvertoryDB;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            //Check if user exists
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string checkUser = "select count(*) from loginData where username = '" + username + "' and password = '" + password + "'";
            using (SqlCommand check = new SqlCommand(checkUser, con))
            {
                int count = (int)check.ExecuteScalar();

                if (count >= 1)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                    MessageBox.Show("Login successfull!", "Account information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Wrong username or password!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
