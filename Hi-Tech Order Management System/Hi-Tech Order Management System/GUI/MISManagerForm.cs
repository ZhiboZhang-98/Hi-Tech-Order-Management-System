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
    public partial class MISManagerForm : Form
    {
        protected static string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\HiTechDB.mdf;";// Integrated Security = True";
        protected SqlConnection connection = new SqlConnection(connectionString);
        //SqlConnection connection = UtilityDB.connDB();
        public MISManagerForm()
        {
            InitializeComponent();
            connection.Open();
            Add.Hide();
            dataGridViewUser.Hide();
            dataGridViewEmployee.Hide();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.SetDesktopLocation(0, 0);
            loginForm.BringToFront();
            loginForm.Show();
        }

        private void comboBoxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEmployeeType.Text = "";
            comboBoxSelectionType.Text = "";
            textBoxId.Text = "";
            if (comboBoxSelection.Text == "User")
            {
                Add.Hide();
                dataGridViewEmployee.Hide();
                dataGridViewUser.BringToFront();
                dataGridViewUser.Show();

                String query = "SELECT Distinct * From Customer";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                int n = 0;
                dataGridViewUser.Rows.Clear();
                while (reader.Read())
                {
                    n = dataGridViewUser.Rows.Add();
                    dataGridViewUser.Rows[n].Cells[0].Value = reader["ID"].ToString();
                    dataGridViewUser.Rows[n].Cells[1].Value = reader["Name"].ToString();
                    dataGridViewUser.Rows[n].Cells[2].Value = reader["Street"].ToString();
                    dataGridViewUser.Rows[n].Cells[3].Value = reader["City"].ToString();
                    dataGridViewUser.Rows[n].Cells[4].Value = reader["PostalCode"].ToString();
                    dataGridViewUser.Rows[n].Cells[5].Value = reader["PhoneNumber"].ToString();
                    dataGridViewUser.Rows[n].Cells[6].Value = reader["FaxNumber"].ToString();
                    dataGridViewUser.Rows[n].Cells[7].Value = reader["CreditLimit"].ToString();
                }
                reader.Close();
                dataGridViewUser.AllowUserToAddRows = false;
                dataGridViewUser.AllowUserToDeleteRows = false;
                dataGridViewUser.AllowUserToResizeColumns = true;

            }
            else if (comboBoxSelection.Text == "Employee")
            {
                Add.Hide();
                dataGridViewUser.Hide();
                dataGridViewEmployee.BringToFront();
                dataGridViewEmployee.Show();

                String query = "SELECT Distinct * From Users";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                int n = 0;
                dataGridViewEmployee.Rows.Clear();
                while (reader.Read())
                {
                    n = dataGridViewEmployee.Rows.Add();
                    dataGridViewEmployee.Rows[n].Cells[0].Value = reader["ID"].ToString();
                    dataGridViewEmployee.Rows[n].Cells[1].Value = reader["Type"].ToString();
                    dataGridViewEmployee.Rows[n].Cells[2].Value = reader["Name"].ToString();
                }
                reader.Close();
                dataGridViewEmployee.AllowUserToAddRows = false;
                dataGridViewEmployee.AllowUserToDeleteRows = false;
                dataGridViewEmployee.AllowUserToResizeColumns = true;
            }
        }

        private void buttonCRUDOperation_Click(object sender, EventArgs e)
        {
            dataGridViewUser.Hide();
            dataGridViewEmployee.Hide();
            Add.BringToFront();
            Add.Show();
        }

        private void comboBoxSelectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEmployeeType.Text = "";
            comboBoxSelection.Text = "";
            if (textBoxId.Text != "")
            {
                if (comboBoxSelectionType.Text == "User")
                {
                    Add.Hide();
                    dataGridViewEmployee.Hide();
                    dataGridViewUser.BringToFront();
                    dataGridViewUser.Show();

                    String query = "SELECT Distinct * From Customer where ID='" + textBoxId.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    int n = 0;
                    dataGridViewUser.Rows.Clear();
                    while (reader.Read())
                    {
                        n = dataGridViewUser.Rows.Add();
                        dataGridViewUser.Rows[n].Cells[0].Value = reader["ID"].ToString();
                        dataGridViewUser.Rows[n].Cells[1].Value = reader["Name"].ToString();
                        dataGridViewUser.Rows[n].Cells[2].Value = reader["Street"].ToString();
                        dataGridViewUser.Rows[n].Cells[3].Value = reader["City"].ToString();
                        dataGridViewUser.Rows[n].Cells[4].Value = reader["PostalCode"].ToString();
                        dataGridViewUser.Rows[n].Cells[5].Value = reader["PhoneNumber"].ToString();
                        dataGridViewUser.Rows[n].Cells[6].Value = reader["FaxNumber"].ToString();
                        dataGridViewUser.Rows[n].Cells[7].Value = reader["CreditLimit"].ToString();
                    }
                    reader.Close();
                }
                else if (comboBoxSelectionType.Text == "Employee")
                {
                    Add.Hide();
                    dataGridViewUser.Hide();
                    dataGridViewEmployee.BringToFront();
                    dataGridViewEmployee.Show();

                    String query = "SELECT Distinct * From Users where ID='" + textBoxId.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    int n = 0;
                    dataGridViewEmployee.Rows.Clear();
                    while (reader.Read())
                    {
                        n = dataGridViewEmployee.Rows.Add();
                        dataGridViewEmployee.Rows[n].Cells[0].Value = reader["ID"].ToString();
                        dataGridViewEmployee.Rows[n].Cells[1].Value = reader["Type"].ToString();
                        dataGridViewEmployee.Rows[n].Cells[2].Value = reader["Name"].ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void comboBoxEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelection.Text = "";
            comboBoxSelectionType.Text = "";
            textBoxId.Text = "";
            Add.Hide();
            dataGridViewUser.Hide();
            dataGridViewEmployee.BringToFront();
            dataGridViewEmployee.Show();

            String query = "SELECT Distinct * From Users where Type='" + comboBoxEmployeeType.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            int n = 0;
            dataGridViewEmployee.Rows.Clear();
            while (reader.Read())
            {
                n = dataGridViewEmployee.Rows.Add();
                dataGridViewEmployee.Rows[n].Cells[0].Value = reader["ID"].ToString();
                dataGridViewEmployee.Rows[n].Cells[1].Value = reader["Type"].ToString();
                dataGridViewEmployee.Rows[n].Cells[2].Value = reader["Name"].ToString();
            }
            reader.Close();
        }


        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || streetTextBox.Text == "" || cityTextBox.Text == "" || postalCodeTextBox.Text == "" || phoneNumberTextBox.Text == "" || faxNumberTextBox.Text == "" || creditLimitTextBox.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                String query = "insert into Customer values('" + userNameTextBox.Text + "','" + streetTextBox.Text + "','" + cityTextBox.Text + "'," + postalCodeTextBox.Text + ",'" + phoneNumberTextBox.Text + "','" + faxNumberTextBox.Text + "','" + creditLimitTextBox.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("User Added.");
            }
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeeNameTextBox.Text == "" || employeeTypeComboBox.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                String query = "insert into Users values('" + employeeNameTextBox.Text + "','" + employeeTypeComboBox.Text + "','1234')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Employee Added.");
            }
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            if (userIDBox.Text=="" || userNameBox.Text == "" || streetBox.Text == "" || cityBox.Text == "" || postalCodeBox.Text == "" || phoneNumberBox.Text == "" || faxNumberBox.Text == "" || creditLimitBox.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                String query = "update Customer set Name='"+ userNameBox.Text + "',Street='"+streetBox.Text+"',City='"+cityBox.Text+"',PostalCode='"+postalCodeBox.Text+"',PhoneNumber='"+phoneNumberBox.Text+"',FaxNumber='"+faxNumberBox.Text+"',CreditLimit='"+creditLimitBox.Text+"'where ID='"+userIDBox.Text+"'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("User Updated.");
            }
        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeeIDBox.Text == "" || employeeNameBox.Text == "" || employeeTypeBox.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                String query = "update Users set Type='"+employeeTypeBox.Text+"',Name='" + employeeNameBox.Text + "'where ID='"+employeeIDBox.Text+"'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Employee Updated.");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (textBoxSearchUserId.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                String query = "delete from Customer where ID='"+textBoxSearchUserId.Text+"'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("User Deleted.");
            }
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (textBoxSearchEmployeeId.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                String query = "delete from Users where ID='" + textBoxSearchEmployeeId.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted.");
            }
        }

    }
}
