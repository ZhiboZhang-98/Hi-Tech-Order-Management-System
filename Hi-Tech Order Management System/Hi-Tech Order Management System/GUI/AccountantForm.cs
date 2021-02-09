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
    public partial class AccountantForm : Form
    {
        protected static string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\HiTechDB.mdf;";// Integrated Security = True";
        protected SqlConnection connection = new SqlConnection(connectionString);
        //SqlConnection connection = UtilityDB.connDB();

        public AccountantForm()
        {
            InitializeComponent();
            Add.Hide();
            dataGridViewInvoice.Hide();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.SetDesktopLocation(0, 0);
            loginForm.BringToFront();
            loginForm.Show();
        }


        private void buttonList_Click(object sender, EventArgs e)
        {
            textBoxInvoiceId.Text = "";
            Add.Hide();
            dataGridViewInvoice.BringToFront();
            dataGridViewInvoice.Show();

            String query = "SELECT Distinct * FROM Orders a INNER JOIN BOOK b ON a.BookID=b.ISBN INNER JOIN Customer c ON customerID=c.ID";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            int n = 0;
            dataGridViewInvoice.Rows.Clear();
            while (reader.Read())
            {
                n = dataGridViewInvoice.Rows.Add();
                dataGridViewInvoice.Rows[n].Cells[0].Value = reader["ID"].ToString();
                dataGridViewInvoice.Rows[n].Cells[1].Value = reader["CustomerID"].ToString();
                dataGridViewInvoice.Rows[n].Cells[2].Value = reader["BookID"].ToString();
                dataGridViewInvoice.Rows[n].Cells[2].Value = reader["UnitPrice"].ToString();
            }
            reader.Close();
            connection.Close();
            dataGridViewInvoice.AllowUserToAddRows = false;
            dataGridViewInvoice.AllowUserToDeleteRows = false;
            dataGridViewInvoice.AllowUserToResizeColumns = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewInvoice.Hide();
            Add.BringToFront();
            Add.Show();

            String query = "SELECT Distinct * FROM Orders a INNER JOIN BOOK b ON a.BookID=b.ISBN INNER JOIN Customer c ON customerID=c.ID where a.ID='"+textBoxInvoiceId.Text+"'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            dataGridViewInvoice.Rows.Clear();
            if (reader.Read())
            {
                orderIDTextBox.Text = reader["ID"].ToString();
                customerIDTextBox.Text = reader["CustomerID"].ToString();
                ISBNTextBox.Text = reader["BookID"].ToString();
                priceTextBox.Text = reader["UnitPrice"].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print Successfully", "Confirmation");
        }
    }
}
