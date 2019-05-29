using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authentication;

namespace OOSELab5.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void lbSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp form = new SignUp();
            form.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Please enter a username", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (txtUsername.Text.Length < 3)
                {
                    MessageBox.Show("Username must be atleast 3-digits long", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter a password", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show("Password must be atleast 6-digits long", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (User.SignIn(txtUsername.Text,txtPassword.Text))
                    {
                        this.Hide();
                        Dashboard form = new Dashboard();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
