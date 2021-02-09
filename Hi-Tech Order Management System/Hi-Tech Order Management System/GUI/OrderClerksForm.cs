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
using Hi_Tech_Order_Management_System.Business;
using Hi_Tech_Order_Management_System.DataAccess;

namespace Hi_Tech_Order_Management_System
{
    public partial class OrderClerksForm : Form
    {
        protected static string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\HiTechDB.mdf;";// Integrated Security = True";
        protected SqlConnection connection = new SqlConnection(connectionString);
        //SqlConnection connection = UtilityDB.connDB();

        public OrderClerksForm()
        {
            InitializeComponent();
            Add.Hide();
            dataGridViewOrder.Hide();
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
            dataGridViewOrder.Hide();
            Add.BringToFront();
            Add.Show();
        }

        private void comboBoxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectionType.Text = "";
            textBoxInputOrderId.Text = "";
            if (comboBoxSelection.Text == "Order")
            {
                Add.Hide();
                dataGridViewOrder.BringToFront();
                dataGridViewOrder.Show();

                String query = "SELECT * FROM Orders";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                int n = 0;
                dataGridViewOrder.Rows.Clear();
                while (reader.Read())
                {
                    n = dataGridViewOrder.Rows.Add();
                    dataGridViewOrder.Rows[n].Cells[0].Value = reader["ID"].ToString();
                    dataGridViewOrder.Rows[n].Cells[1].Value = reader["CustomerID"].ToString();
                    dataGridViewOrder.Rows[n].Cells[2].Value = reader["BookID"].ToString();
                }
                reader.Close();
                connection.Close();
                dataGridViewOrder.AllowUserToAddRows = false;
                dataGridViewOrder.AllowUserToDeleteRows = false;
                dataGridViewOrder.AllowUserToResizeColumns = true;
            }
        }

        private void comboBoxSelectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelection.Text = "";
            if (textBoxInputOrderId.Text != "")
            {
                if (comboBoxSelectionType.Text == "Order")
                {
                    Add.Hide();
                    dataGridViewOrder.BringToFront();
                    dataGridViewOrder.Show();

                    String query = "SELECT Distinct * From Orders Where ID='" + textBoxInputOrderId.Text + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    int n = 0;
                    dataGridViewOrder.Rows.Clear();
                    while (reader.Read())
                    {
                        n = dataGridViewOrder.Rows.Add();
                        dataGridViewOrder.Rows[n].Cells[0].Value = reader["ID"].ToString();
                        dataGridViewOrder.Rows[n].Cells[1].Value = reader["CustomerID"].ToString();
                        dataGridViewOrder.Rows[n].Cells[2].Value = reader["BookID"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void orderBookButton_Click(object sender, EventArgs e)
        {
            if (customerIDTextBox.Text == "" || ISBNTextBox.Text == "")
                MessageBox.Show("Please Fill All boxex.");
            else
            {
                Orders order = new Orders();
                order.customerID = customerIDTextBox.Text;
                order.ISBN = ISBNTextBox.Text;
                String query = "select count(*) from customer where ID='" + order.customerID + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int n = Convert.ToInt32(command.ExecuteScalar());
                if (n == 0)
                    MessageBox.Show("Customer ID Not Exist.");
                else
                {
                    query = "select count(*) From Book where ISBN='" + order.ISBN + "'";
                    command = new SqlCommand(query, connection);
                    n = Convert.ToInt32(command.ExecuteScalar());
                    if (n == 0)
                        MessageBox.Show("ISBN Not Exist.");
                    else
                    {
                        query = "insert into Orders values('" + order.customerID + "','" + order.ISBN + "')";
                        command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Add Successfully");
                    }
                }
                connection.Close();
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            if (deleteID.Text == "")
                MessageBox.Show("Please Enter ID.");
            else
            {
                Orders order = new Orders();
                order.ID = deleteID.Text;
                String query = "delete from Orders where ID='" + order.ID + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void updateOrderButton_Click(object sender, EventArgs e)
        {
            if (textBoxOrderId.Text == "" || textBoxCustomerId.Text == "" || textBoxISBN.Text == "")
                MessageBox.Show("Please Fill All Boxex.");
            else
            {
                Orders order = new Orders();
                order.ID = textBoxOrderId.Text;
                order.customerID = textBoxCustomerId.Text;
                order.ISBN = textBoxISBN.Text;

                String query = "select count(*) from customer where ID='" + order.customerID + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int n = Convert.ToInt32(command.ExecuteScalar());
                if (n == 0)
                    MessageBox.Show("Customer ID Not Exist.");
                else
                {
                    query = "select count(*) From Book where ISBN='" + order.ISBN + "'";
                    command = new SqlCommand(query, connection);
                    n = Convert.ToInt32(command.ExecuteScalar());
                    if (n == 0)
                        MessageBox.Show("ISBN Not Exist.");
                    else
                    {
                        query = "Update Orders set CustomerID='" + order.customerID + "',ISBN='" + order.ISBN + "' where ID='" + order.ID + "'";
                        command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
        }

    }
}
