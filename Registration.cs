using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Project2
{
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length < 3)
            {
                validFirstNameLabel.Text = "Името трябва да съдържа поне три символа.";
                RegisterButton.Enabled = false;
            }
            else
            {
                validFirstNameLabel.Text = string.Empty;

                if (LastNameTextBox.Text.Length > 2 && UsernameTextBox.Text.Length > 2 && PasswordTextBox.Text.Length > 1)
                {
                    RegisterButton.Enabled = true;
                }
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length < 3)
            {
                validLastNameLabel.Text = "Фамилията трябва да съдържа поне три символа.";
                RegisterButton.Enabled = false;
            }
            else
            {
                validLastNameLabel.Text = string.Empty;

                if (FirstNameTextBox.Text.Length > 2 && UsernameTextBox.Text.Length > 2 && PasswordTextBox.Text.Length > 1)
                {
                    RegisterButton.Enabled = true;
                }
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length < 3)
            {
                validUsernameLabel.Text = "Потребителското име трябва да съдържа поне три символа.";
                RegisterButton.Enabled = false;
            }
            else
            {
                validUsernameLabel.Text = string.Empty;

                if (FirstNameTextBox.Text.Length > 2 && LastNameTextBox.Text.Length > 2 && PasswordTextBox.Text.Length > 1)
                {
                    RegisterButton.Enabled = true;
                }
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length < 2)
            {
                validPasswordLabel.Text = "Паролата трябва да има поне два символа.";
                RegisterButton.Enabled = false;
            }
            else
            {
                validPasswordLabel.Text = string.Empty;

                if (FirstNameTextBox.Text.Length > 2 && LastNameTextBox.Text.Length > 2 && UsernameTextBox.Text.Length > 2)
                {
                    RegisterButton.Enabled = true;
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
             string firstName = FirstNameTextBox.Text;
             string lastName = LastNameTextBox.Text;
             string username = UsernameTextBox.Text;
             string password = PasswordTextBox.Text;

             User user = new User()
             {
                 FirstName = firstName,
                 LastName = lastName,
                 UserName = username,
                 Pass = password,
                 Role = 1
             };

             using (HouseContext houseContext = new HouseContext())
             {
                 houseContext.Users.Add(user);
                 houseContext.SaveChanges();
                 Close();
             }
         }
    }
}
