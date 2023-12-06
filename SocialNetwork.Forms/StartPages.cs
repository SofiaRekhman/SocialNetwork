using SocialNetwork.DAL;
using SocialNetwork.Domain.BLL;
using SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SocialNetwork.Forms
{
    public partial class StartPages : Form
    {
        public StartPages()
        {
            InitializeComponent();
        }
        private readonly UserPage _userPage = new UserPage();

        private void buttomLogin_Click_1(object sender, EventArgs e)
        {
            try
            {

                string userId = ReturnUserId();
                _userPage.FillInUserInformation(userId);
                _userPage.Show();
                this.Hide();
                MessageBox.Show($"login was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLogin.Clear(); tbPassword.Clear();
            }
        }

        public string ReturnUserId()
        {
            return UsersDAL.CheckLogin(tbLogin.Text, tbPassword.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbLogin.Text = "Username";
            tbLogin_Enter_1(sender, e);
            tbLogin_Leave_1(sender, e);

            tbPassword.Text = "Password";
            tbPassword_Enter_1(sender, e);
            tbPassword_Leave_1(sender, e);

            tbFirstnameSignIn.Text = "Firstname";
            tbFirstnameSignIn_Enter(sender, e);
            tbFirstnameSignIn_Leave(sender, e);

            tbLastNameSignIn.Text = "Lastname";
            tbLastNameSignIn_Enter(sender, e);
            tbLastNameSignIn_Leave(sender, e);

            tbUsernameSignIn.Text = "Username";
            tbUsernameSignIn_Enter(sender, e);
            tbUsernameSignIn_Leave(sender, e);

            tbEmailSignIn.Text = "Email";
            tbEmailSignIn_Enter(sender, e);
            tbEmailSignIn_Leave(sender, e);

            tbPasswordSignIn.Text = "Password";
            tbPasswordSignIn_Enter(sender, e);
            tbPasswordSignIn_Leave(sender, e);

            tbUsernameDelete.Text = "Username";
            tbUsernameDelete_Enter(sender, e);
            tbUsernameDelete_Leave(sender, e);

            tbPasswordDelete.Text = "Password";
            tbPasswordDelete_Enter(sender, e);
            tbPasswordDelete_Leave(sender, e);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                var firstName = tbFirstnameSignIn.Text; 
                var lastName = tbLastNameSignIn.Text;   
                var username = tbUsernameSignIn.Text;   
                var email = tbEmailSignIn.Text;
                var password = tbPasswordSignIn.Text;
                UsersDAL.NewUserSignIn(firstName, lastName, email, username, password);
                MessageBox.Show($"Account added succesful", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Account do not added/n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            var userName = tbUsernameDelete.Text;
            var password = tbPasswordDelete.Text;
            var userId = ReturnUserId();
            UsersDAL.DeleteUser(userName, password);
            SocialNetwork.Domain.BLL.UserService.RemoveUser(userId);
            MessageBox.Show($"Account deleted succesful", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbLogin_Enter_1(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Username")
            {
                tbLogin.Text = "";
                tbLogin.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbLogin_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                tbLogin.Text = "Username";
                tbLogin.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbPassword_Enter_1(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbPassword_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbFirstnameSignIn_Enter(object sender, EventArgs e)
        {
            if (tbFirstnameSignIn.Text == "Firstname")
            {
                tbFirstnameSignIn.Text = "";
                tbFirstnameSignIn.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbFirstnameSignIn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstnameSignIn.Text))
            {
                tbFirstnameSignIn.Text = "Firstname";
                tbFirstnameSignIn.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbLastNameSignIn_Enter(object sender, EventArgs e)
        {
            if (tbLastNameSignIn.Text == "Lastname")
            {
                tbLastNameSignIn.Text = "";
                tbLastNameSignIn.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbLastNameSignIn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLastNameSignIn.Text))
            {
                tbLastNameSignIn.Text = "Lastname";
                tbLastNameSignIn.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbUsernameSignIn_Enter(object sender, EventArgs e)
        {
            if (tbUsernameSignIn.Text == "Username")
            {
                tbUsernameSignIn.Text = "";
                tbUsernameSignIn.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbUsernameSignIn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsernameSignIn.Text))
            {
                tbUsernameSignIn.Text = "Username";
                tbUsernameSignIn.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbEmailSignIn_Enter(object sender, EventArgs e)
        {
            if (tbEmailSignIn.Text == "Email")
            {
                tbEmailSignIn.Text = "";
                tbEmailSignIn.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbEmailSignIn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmailSignIn.Text))
            {
                tbEmailSignIn.Text = "Email";
                tbEmailSignIn.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbPasswordSignIn_Enter(object sender, EventArgs e)
        {
            if (tbPasswordSignIn.Text == "Password")
            {
                tbPasswordSignIn.Text = "";
                tbPasswordSignIn.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbPasswordSignIn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPasswordSignIn.Text))
            {
                tbPasswordSignIn.Text = "Password";
                tbPasswordSignIn.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbUsernameDelete_Enter(object sender, EventArgs e)
        {
            if (tbUsernameDelete.Text == "Username")
            {
                tbUsernameDelete.Text = "";
                tbUsernameDelete.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbUsernameDelete_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsernameDelete.Text))
            {
                tbUsernameDelete.Text = "Username";
                tbUsernameDelete.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbPasswordDelete_Enter(object sender, EventArgs e)
        {

            if (tbPasswordDelete.Text == "Password")
            {
                tbPasswordDelete.Text = "";
                tbPasswordDelete.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbPasswordDelete_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPasswordDelete.Text))
            {
                tbPasswordDelete.Text = "Password";
                tbPasswordDelete.ForeColor = SystemColors.GrayText;
            }
        }

       
    }
}
