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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkingconnectionLabel_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection();

                connection.ConnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
                connection.Open();

                checkingconnectionLabel.Text = "Connection Successful";

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex);
            }

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();

            command.Connection = connection;
            command.CommandText = "Select * From customers";

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void recordcountButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();

            command.Connection = connection;
            command.CommandText = "Select count(*) From customers";

            int count = (int)command.ExecuteScalar();
            recordcountLabel.Text = count.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            connection.Open();

            command.Connection = connection;
            command.CommandText = "insert into Customers (CustomerID, CompanyName) values('" + idTextBox.Text + "','" + companyTextBox.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Data Saved");
            connection.Close();
        }

        private void employeeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
