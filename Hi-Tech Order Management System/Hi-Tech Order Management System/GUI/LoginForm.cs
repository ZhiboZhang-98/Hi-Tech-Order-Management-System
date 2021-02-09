using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hi_Tech_Order_Management_System.GUI;
using Hi_Tech_Order_Management_System.DataAccess;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class LoginForm : Form
    {
        protected static string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\HiTechDB.mdf;";
        protected SqlConnection connection = new SqlConnection(connectionString);
        //SqlConnection connection = UtilityDB.connDB();
        public LoginForm()
        {
            InitializeComponent();
            this.SetDesktopLocation(0, 0);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            userNameRequiredLabel.Hide();
            passwordRequiredLabel.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
                userNameRequiredLabel.Show();
            else userNameRequiredLabel.Hide();
            if (textBoxPassword.Text == "")
                passwordRequiredLabel.Show();
            else passwordRequiredLabel.Hide();
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                String query = "SELECT * FROM Users WHERE Name='" + textBoxUsername.Text + "' AND Password='" + textBoxPassword.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                string type = "";
                int count = 0;
                while (reader.Read())
                {
                    count++;
                    type = reader["Type"].ToString();
                }
                connection.Close();
                if (count == 1)
                {
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                    this.Hide();
                    switch (type.ToUpper())
                    {
                        case "MIS MANAGER":
                            MISManagerForm mm = new MISManagerForm();
                            mm.SetDesktopLocation(0, 0);
                            mm.BringToFront();
                            mm.Show();
                            break;
                        case "SALES MANAGER":
                            SalesManagerForm sm = new SalesManagerForm();
                            sm.SetDesktopLocation(0, 0);
                            sm.BringToFront();
                            sm.Show();
                            break;
                        case "ORDER CLERKS":
                            OrderClerksForm oc = new OrderClerksForm();
                            oc.SetDesktopLocation(0, 0);
                            oc.BringToFront();
                            oc.Show();
                            break;
                        case "ACCOUNTANT":
                            AccountantForm a = new AccountantForm();
                            a.SetDesktopLocation(0, 0);
                            a.BringToFront();
                            a.Show();
                            break;
                        case "INVENTORY CONTROLLER":
                            InventoryControllerForm ic = new InventoryControllerForm();
                            ic.SetDesktopLocation(0, 0);
                            ic.BringToFront();
                            ic.Show();
                            break;
                    }
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
