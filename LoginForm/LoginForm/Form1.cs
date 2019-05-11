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

namespace LoginForm
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        //Login button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Create db connection, uses query to return the resulting data in the database
            SqlConnection conn = new SqlConnection(@" Data Source=DESKTOP-45EM3EC\SQLEXPRESS;Initial Catalog=userLogin;Integrated Security=True");
            string query = "SELECT * FROM logins where username = '" + usernameTextBox.Text.Trim() + "' AND password= '" + passwordTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            //If we find that there is a matching row or more than one matching row login else show message
            if (dtbl.Rows.Count >= 1)
            {
                formLoggedIn objformLoggedIn = new formLoggedIn();
                objformLoggedIn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
