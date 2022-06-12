using System;
using System.Linq;
using System.Windows.Forms;


namespace House_Project2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length < 3)
            {
                Usernametext.Text = "Потребителското име трябва да има поне три символа.";
                logButton.Enabled = false;
            }
            else
            {
                Usernametext.Text = string.Empty;

                if (Password.Text.Length > 1)
                {
                    logButton.Enabled = true;
                }
            }
        }

        private void Password_TextChanged_1(object sender, EventArgs e)
        {
            if (Password.Text.Length < 2)
            {
                Passtext.Text = "Паролата трябва да има поне два символа.";
                logButton.Enabled = false;
            }
            else
            {
                Passtext.Text = string.Empty;

                if (usernameTextBox.Text.Length > 2)
                {
                    logButton.Enabled = true;
                }
            }
        }
        private void logButton_Click(object sender, EventArgs e)
        {

            string username = usernameTextBox.Text;
            string password = Password.Text;

            User foundUser;

            using (HouseContext houseContext = new HouseContext())
            {
                foundUser = houseContext.Users.FirstOrDefault(user => user.UserName == username);
            }

            if (foundUser != null)
            {
                if (foundUser.Pass == password)
                {
                    Registrator.LoggedUser = foundUser;
            
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
            
                }
                else
                {
                    MessageBox.Show("Грешна парола.", "Некоректен вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Няма такъв потребител.", "Некоректен вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void registerLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registrationform = new Registration();
            registrationform.Show();
        }

        private void FreeView_Click_1(object sender, EventArgs e)
        {
            ClientView clientView = new ClientView();
            clientView.Show();
        }

    }
}

     
