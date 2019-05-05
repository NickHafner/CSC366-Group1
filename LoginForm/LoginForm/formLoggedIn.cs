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

        private void LoginFormLogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            loginForm objformLogIn = new loginForm();
            this.Hide();
            objformLogIn.Show();
        }
    }
}
