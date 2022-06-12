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
    public partial class ViewUsersForm : Form
    {
        public ViewUsersForm()
        {
            InitializeComponent();
        }

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            List<Role> roles;

            using (HouseContext carDealerContext = new HouseContext())
            {
                roles = carDealerContext.Roles.OrderBy(role => role.Id).ToList();
            }

            roleComboBox.ValueMember = "Id";
            roleComboBox.DisplayMember = "Name";
            roleComboBox.DataSource = roles;
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roledId = (int)roleComboBox.SelectedValue;

            using (HouseContext houseContext = new HouseContext())
            {
                List<User> filteredUsers = houseContext.Users.Where(user => user.Role == roledId).ToList();

                PopulateListView(filteredUsers);
            }
        }

        private void PopulateListView(List<User> users)
        {
            listViewUsers.Items.Clear();

            foreach (User user in users)
            {
                string[] rowData = new string[] { user.FirstName, user.LastName, user.UserName };
                ListViewItem item = new ListViewItem(rowData);
                listViewUsers.Items.Add(item);
            }
        }
    }
}
