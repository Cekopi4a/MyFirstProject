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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            User loggedUser = Registrator.LoggedUser;

            using (HouseContext houseContext = new HouseContext())
            {
                
                User foundUser = houseContext.Users.Find(loggedUser.Id);
                nameUserLabel.Text = "Добре дошъл:" + loggedUser.FirstName;

                if (foundUser.Role1.Name == "Admin")
                {
                    categorieGroupBox.Visible = true;
                    townGroupBox.Visible = true;
                    userGroupBox.Visible = true;
                }
            }
        }

        private void ViewHouse_Click(object sender, EventArgs e)
        {
            chouseHouse ChouseHouse = new chouseHouse();
            ChouseHouse.Show();
        }

        private void ChangeHouse_Click(object sender, EventArgs e)
        {
           ChangeCategorieForm changeCategorieForm = new ChangeCategorieForm();
            changeCategorieForm.Show();
        }

        private void ChangeUsers_Click(object sender, EventArgs e)
        {
            ChangeUsersForm changeUserForm = new ChangeUsersForm();
            changeUserForm.Show();
        }

        private void ReviewUsers_Click(object sender, EventArgs e)
        {
            ViewUsersForm viewUsersForm = new ViewUsersForm();
            viewUsersForm.Show();
        }

        private void ChangeCategories_Click(object sender, EventArgs e)
        {
            ChangeHouseForm changeHouseForm = new ChangeHouseForm();
            changeHouseForm.Show();
        }

        private void ChangeTypes_Click(object sender, EventArgs e)
        {
            ChangeTownForm changeTownForm = new ChangeTownForm();
            changeTownForm.Show();
        }


    }
}
