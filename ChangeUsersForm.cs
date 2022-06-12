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
    public partial class ChangeUsersForm : Form
    {
        private User currentUser;
        public ChangeUsersForm()
        {
            InitializeComponent();
        }

        private void ChangeUsersForm_Load(object sender, EventArgs e)
        {
            List<Role> roles;

            using (HouseContext houseContext = new HouseContext())
            {
                roles = houseContext.Roles.OrderBy(role => role.Id).ToList();
                currentUser = houseContext.Users.First();
            }

            roleComboBox.ValueMember = "Id";
            roleComboBox.DisplayMember = "Name";
            roleComboBox.DataSource = roles;

            PopulateControls();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            using (HouseContext houseContext = new HouseContext())
            {
                User oldUser = houseContext.Users.Find(currentUser.Id);

                User newUser = new User()
                {
                    Id = currentUser.Id,
                    FirstName = firstNameDataLabel.Text,
                    LastName = lastNameDataLabel.Text,
                    UserName = usernameDataLabel.Text,
                    Pass = currentUser.Pass,
                    Role = (int)roleComboBox.SelectedValue
                };

                houseContext.Entry(oldUser).CurrentValues.SetValues(newUser);
                houseContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (HouseContext houseContext = new HouseContext())
            {
                User user = houseContext.Users.Find(currentUser.Id);
                houseContext.Users.Remove(user);
                houseContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            prevButton.Enabled = true;

            using (HouseContext houseContext = new HouseContext())
            {
                List<User> nextUsers = houseContext.Users
                    .Where(user => user.Id > currentUser.Id)
                    .OrderBy(user => user.Id)
                    .ToList();

                if (nextUsers.Count > 0)
                {
                    currentUser = nextUsers.First();
                    PopulateControls();
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (HouseContext houseContext = new HouseContext())
            {
                List<User> prevUsers = houseContext.Users
                    .Where(user => user.Id < currentUser.Id)
                    .OrderBy(user => user.Id)
                    .ToList();

                if (prevUsers.Count > 0)
                {
                    currentUser = prevUsers.Last();
                    PopulateControls();
                }
                else
                {
                    prevButton.Enabled = false;
                }
            }
        }
        private void PopulateControls()
        {
            firstNameDataLabel.Text = currentUser.FirstName;
            lastNameDataLabel.Text = currentUser.LastName;
            usernameDataLabel.Text = currentUser.UserName;
            roleComboBox.SelectedValue = currentUser.Role;
        }

    }
}
