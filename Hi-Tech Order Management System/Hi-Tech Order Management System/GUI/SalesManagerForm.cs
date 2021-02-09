using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Hi_Tech_Order_Management_System.GUI;
using Hi_Tech_Order_Management_System.DataAccess;

namespace Hi_Tech_Order_Management_System
{
    public partial class SalesManagerForm : Form
    {
        protected static string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\HiTechDB.mdf;";// Integrated Security = True";
        protected SqlConnection connection = new SqlConnection(connectionString);
        //SqlConnection connection = UtilityDB.connDB();

        public SalesManagerForm()
        {
            InitializeComponent();
            Add.Hide();
            dataGridViewCustomer.Hide();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.SetDesktopLocation(0, 0);
            loginForm.BringToFront();
            loginForm.Show();
        }

        private void buttonCRUDOperation_Click(object sender, EventArgs e)
        {
            dataGridViewCustomer.Hide();
            Add.BringToFront();
            Add.Show();
        }

        private void comboBoxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectionType.Text = "";
            textBoxInputId.Text = "";
            if (comboBoxSelection.Text == "Customer")
            {
                Add.Hide();
                dataGridViewCustomer.BringToFront();
                dataGridViewCustomer.Show();

                String query = "SELECT Distinct * From Customer";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                int n = 0;
                dataGridViewCustomer.Rows.Clear();
                while (reader.Read())
                {
                    n = dataGridViewCustomer.Rows.Add();
                    dataGridViewCustomer.Rows[n].Cells[0].Value = reader["ID"].ToString();
                    dataGridViewCustomer.Rows[n].Cells[1].Value = reader["Name"].ToString();
                    dataGridViewCustomer.Rows[n].Cells[2].Value = reader["Street"].ToString();
                    dataGridViewCustomer.Rows[n].Cells[3].Value = reader["City"].ToString();
                    dataGridViewCustomer.Rows[n].Cells[4].Value = reader["PostalCode"].ToString();
                    dataGridViewCustomer.Rows[n].Cells[5].Value = reader["PhoneNumber"].ToString();
                    dataGridViewCustomer.Rows[n].Cells[6].Value = reader["FaxNumber"].ToString();
                    dataGridViewCustomer.Rows[n].Cells[7].Value = reader["CreditLimit"].ToString();
                }
                reader.Close();
                connection.Close();
                dataGridViewCustomer.AllowUserToAddRows = false;
                dataGridViewCustomer.AllowUserToDeleteRows = false;
                dataGridViewCustomer.AllowUserToResizeColumns = true;
            }
        }

        private void comboBoxSelectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelection.Text = "";
            if (textBoxInputId.Text != "")
            {
                if (comboBoxSelectionType.Text == "Customer")
                {
                    Add.Hide();
                    dataGridViewCustomer.BringToFront();
                    dataGridViewCustomer.Show();

                    String query = "SELECT Distinct * From Customer where ID='" + textBoxInputId.Text + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    int n = 0;
                    dataGridViewCustomer.Rows.Clear();
                    while (reader.Read())
                    {
                        n = dataGridViewCustomer.Rows.Add();
                        dataGridViewCustomer.Rows[n].Cells[0].Value = reader["ID"].ToString();
                        dataGridViewCustomer.Rows[n].Cells[1].Value = reader["Name"].ToString();
                        dataGridViewCustomer.Rows[n].Cells[2].Value = reader["Street"].ToString();
                        dataGridViewCustomer.Rows[n].Cells[3].Value = reader["City"].ToString();
                        dataGridViewCustomer.Rows[n].Cells[4].Value = reader["PostalCode"].ToString();
                        dataGridViewCustomer.Rows[n].Cells[5].Value = reader["PhoneNumber"].ToString();
                        dataGridViewCustomer.Rows[n].Cells[6].Value = reader["FaxNumber"].ToString();
                        dataGridViewCustomer.Rows[n].Cells[7].Value = reader["CreditLimit"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || streetTextBox.Text == "" || cityTextBox.Text == "" || postalCodeTextBox.Text == "" || phoneNumberTextBox.Text == "" || faxNumberTextBox.Text == "" || creditLimitTextBox.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                String query = "insert into Customer values('" + userNameTextBox.Text + "','" + streetTextBox.Text + "','" + cityTextBox.Text + "'," + postalCodeTextBox.Text + ",'" + phoneNumberTextBox.Text + "','" + faxNumberTextBox.Text + "','" + creditLimitTextBox.Text + "')";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer Added.");
            }
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            if (userIDBox.Text == "" || userNameBox.Text == "" || streetBox.Text == "" || cityBox.Text == "" || postalCodeBox.Text == "" || phoneNumberBox.Text == "" || faxNumberBox.Text == "" || creditLimitBox.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                String query = "update Customer set Name='" + userNameBox.Text + "',Street='" + streetBox.Text + "',City='" + cityBox.Text + "',PostalCode='" + postalCodeBox.Text + "',PhoneNumber='" + phoneNumberBox.Text + "',FaxNumber='" + faxNumberBox.Text + "',CreditLimit='" + creditLimitBox.Text + "'where ID='" + userIDBox.Text + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer Updated.");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (textBoxSearchCustomerId.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                String query = "delete from Customer where ID='" + textBoxSearchCustomerId.Text + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer Deleted.");
            }
        }

    }
}
