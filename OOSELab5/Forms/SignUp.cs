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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void lbSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn form = new SignIn();
            form.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text=="")
                {
                    MessageBox.Show("Please enter a username","Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (txtUsername.Text.Length < 3)
                {
                    MessageBox.Show("Username must be atleast 3-digits long", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text=="")
                {
                    MessageBox.Show("Please enter a password", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show("Password must be atleast 6-digits long", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtCPassword.Text == "")
                {
                    MessageBox.Show("Please confirm password", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!txtPassword.Text.Equals(txtCPassword.Text))
                {
                    MessageBox.Show("The Password doesnot match", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (User.CreateAccount(txtUsername.Text, txtCPassword.Text))
                    {
                        MessageBox.Show("You've registered successfully!", "Success",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        SignIn form = new SignIn();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Could not register", "Error",
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
