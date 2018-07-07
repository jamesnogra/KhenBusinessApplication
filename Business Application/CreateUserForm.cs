using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Application
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
            char tempPasswordChar = '■';
            createPassword1Text.PasswordChar = tempPasswordChar;
            createPasswordText.PasswordChar = tempPasswordChar;
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            Login tempLogin = new Login();

            if (createPasswordText.Text != createPassword1Text.Text)
            {
                MessageBox.Show("Password does not match!");
                return;
            }
            if (createUserText.Text.Length < 2)
            {
                MessageBox.Show("Username is too short!");
                return;
            }
            if (createPasswordText.Text.Length < 6)
            {
                MessageBox.Show("Password must be 6 or more characters.");
                return;
            }
            if (!tempLogin.addUser(createUserText.Text, createPasswordText.Text))
            {
                MessageBox.Show("User already exists in the record!");
                return;
            }
            createUserText.Text = "";
            createPasswordText.Text = "";
            createPassword1Text.Text = "";
            MessageBox.Show("User " + createUserText.Text + " has been added to the list.");
        }
    }
}
