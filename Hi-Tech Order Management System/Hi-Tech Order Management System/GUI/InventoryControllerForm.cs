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
    public partial class InventoryControllerForm : Form
    {
        protected static string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\HiTechDB.mdf;";// Integrated Security = True";
        protected SqlConnection connection = new SqlConnection(connectionString);
        //SqlConnection connection = UtilityDB.connDB();
        public InventoryControllerForm()
        {
            InitializeComponent();
            Add.Hide();
            dataGridViewInventory.Hide();
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
            dataGridViewInventory.Hide();
            Add.BringToFront();
            Add.Show();
        }

        private void comboBoxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectionType.Text = "";
            textBoxInputId.Text = "";
            if (comboBoxSelection.Text == "Book")
            {
                Add.Hide();
                dataGridViewInventory.BringToFront();
                dataGridViewInventory.Show();

                String query = "SELECT Distinct ISBN,Title,UnitPrice,YearPublished,QOH,FirstName,LastName,Email,Name FROM Publisher p, Book a INNER JOIN BookAuthor b ON a.ISBN = b.BookID INNER JOIn Author c ON b.AuthorID = c.ID Where PublisherID=p.ID";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                int n = 0;
                dataGridViewInventory.Rows.Clear();
                while (reader.Read())
                {
                    n = dataGridViewInventory.Rows.Add();
                    dataGridViewInventory.Rows[n].Cells[0].Value = reader["ISBN"].ToString();
                    dataGridViewInventory.Rows[n].Cells[1].Value = reader["Title"].ToString();
                    dataGridViewInventory.Rows[n].Cells[2].Value = reader["UnitPrice"].ToString();
                    dataGridViewInventory.Rows[n].Cells[3].Value = reader["YearPublished"].ToString();
                    dataGridViewInventory.Rows[n].Cells[4].Value = reader["QOH"].ToString();
                    dataGridViewInventory.Rows[n].Cells[5].Value = reader["FirstName"].ToString();
                    dataGridViewInventory.Rows[n].Cells[6].Value = reader["LastName"].ToString();
                    dataGridViewInventory.Rows[n].Cells[7].Value = reader["Email"].ToString();
                    dataGridViewInventory.Rows[n].Cells[8].Value = reader["Name"].ToString();
                }
                reader.Close();
                connection.Close();
                dataGridViewInventory.AllowUserToAddRows = false;
                dataGridViewInventory.AllowUserToDeleteRows = false;
                dataGridViewInventory.AllowUserToResizeColumns = true;
            }
        }

        private void comboBoxSelectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelection.Text = "";
            if (textBoxInputId.Text != "")
            {
                if (comboBoxSelectionType.Text == "Book")
                {
                    Add.Hide();
                    dataGridViewInventory.BringToFront();
                    dataGridViewInventory.Show();

                    String query = "SELECT Distinct ISBN,Title,UnitPrice,YearPublished,QOH,FirstName,LastName,Email,Name FROM Publisher p, Book a INNER JOIN BookAuthor b ON a.ISBN = b.BookID INNER JOIn Author c ON b.AuthorID = c.ID Where PublisherID=p.ID AND a.ISBN='" + textBoxInputId.Text + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    int n = 0;
                    dataGridViewInventory.Rows.Clear();
                    while (reader.Read())
                    {
                        n = dataGridViewInventory.Rows.Add();
                        dataGridViewInventory.Rows[n].Cells[0].Value = reader["ISBN"].ToString();
                        dataGridViewInventory.Rows[n].Cells[1].Value = reader["Title"].ToString();
                        dataGridViewInventory.Rows[n].Cells[2].Value = reader["UnitPrice"].ToString();
                        dataGridViewInventory.Rows[n].Cells[3].Value = reader["YearPublished"].ToString();
                        dataGridViewInventory.Rows[n].Cells[4].Value = reader["QOH"].ToString();
                        dataGridViewInventory.Rows[n].Cells[5].Value = reader["FirstName"].ToString();
                        dataGridViewInventory.Rows[n].Cells[6].Value = reader["LastName"].ToString();
                        dataGridViewInventory.Rows[n].Cells[7].Value = reader["Email"].ToString();
                        dataGridViewInventory.Rows[n].Cells[8].Value = reader["Name"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (ISBNTextBox.Text == "" || titleTextBox.Text == "" || unitPriceTextBox.Text == "" || yearPublishedTextBox.Text == "" || QOHTextBox.Text == "" || firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || emailTextBox.Text == "" || publisherNameTextBox.Text == "")
                MessageBox.Show("Please Fill All Boxex.");
            else
            {
                connection.Open();
                String query = "select count(*) From Book where ISBN='" + ISBNTextBox.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int n = Convert.ToInt32(command.ExecuteScalar());
                if (n != 0)
                    MessageBox.Show("ISBN Already Exists.");
                else
                {
                    query = "select count(*) From publisher where Name='" + publisherNameTextBox.Text + "'";
                    command = new SqlCommand(query, connection);
                    n = Convert.ToInt32(command.ExecuteScalar());
                    if (n == 0)
                    {
                        query = "insert into publisher values('" + publisherNameTextBox.Text + "')";
                        command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        query = "select max(ID) from publisher";
                        command = new SqlCommand(query, connection);
                        n = Convert.ToInt32(command.ExecuteScalar());
                    }
                    else
                    {
                        query = "select ID From publisher where Name='" + publisherNameTextBox.Text + "'";
                        command = new SqlCommand(query, connection);
                        n = Convert.ToInt32(command.ExecuteScalar());
                    }

                    query = "insert into Book values('" + ISBNTextBox.Text + "','" + titleTextBox.Text + "','" + unitPriceTextBox.Text + "','" + yearPublishedTextBox.Text + "','" + QOHTextBox.Text + "'," + n + ")";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    query = "insert into Author values('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + emailTextBox.Text + "')";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    query = "select max(ID) from Author";
                    command = new SqlCommand(query, connection);
                    n = Convert.ToInt32(command.ExecuteScalar());
                    query = "insert into BookAuthor values(" + n + ",'" + ISBNTextBox.Text + "')";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Book Added.");
                }
            }
        }

    }
}
