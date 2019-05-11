using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class formLoggedIn : Form
    {
        public formLoggedIn()
        {
            InitializeComponent();
        }

        //This is the exit button; close the application
        private void LoginFormLogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is our logout button, closes current form and re-opens the loginForm
        private void LoginButton_Click(object sender, EventArgs e)
        {
            loginForm objformLogIn = new loginForm();
            objformLogIn.Show();
            this.Hide();
        }
    }
}
