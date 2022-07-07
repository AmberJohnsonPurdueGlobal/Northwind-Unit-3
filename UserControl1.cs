using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class loginForm : UserControl
    {
        public loginForm()
        {
            InitializeComponent();
        }


        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        { }
        public static string username = "";
        public static string password = "";
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else
            {
                var datasource = @"(local)\SQLEXPRESS";
                var database = "Northwind";
                var thisUsername = username;
                var thisPassword = password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
                database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                SqlConnection conn = new SqlConnection(connString);
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection Successful");

                    Form1 frm1 = new Form1();

                    frm1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void paswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
