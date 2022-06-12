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
    public partial class ChangeCategorieForm : Form
    {
        private Estate currentEstate;

        public ChangeCategorieForm()
        {
            InitializeComponent();
        }

        private void ChangeCategorieForm_Load(object sender, EventArgs e)
        {
            List<Category> categories;
            List<HouseType> houseTypes;

            using (HouseContext houseContext = new HouseContext())
            {
                categories = houseContext.Categories.OrderBy(category => category.Id).ToList();
                houseTypes = houseContext.HouseTypes.OrderBy(houseType => houseType.Id).ToList();

                currentEstate = houseContext.Estates.First();
            }

            categorieComboBox.ValueMember = "Id";
            categorieComboBox.DisplayMember = "Name";
            categorieComboBox.DataSource = categories;

            townComboBox.ValueMember = "Id";
            townComboBox.DisplayMember = "Name";
            townComboBox.DataSource = houseTypes;

            PopulateControls();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Estate estate = new Estate()
            {
                Name = adressTextBox.Text,
                Categorie = (int)categorieComboBox.SelectedValue,
                HouseType = (int)townComboBox.SelectedValue,
                Price = (int)priceUpDown.Value
            };

            using (HouseContext houseContext = new HouseContext())
            {
                houseContext.Estates.Add(estate);
                houseContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            using (HouseContext houseContext = new HouseContext())
            {
                Estate oldEstate = houseContext.Estates.Find(currentEstate.Id);
              
                Estate estate = new Estate()
                {
                    Name = adressTextBox.Text,
                    Categorie = (int)categorieComboBox.SelectedValue,
                    HouseType = (int)townComboBox.SelectedValue,
                    Price = (int)priceUpDown.Value
                };

                houseContext.Entry(oldEstate).CurrentValues.SetValues(estate);
                houseContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (HouseContext houseContext = new HouseContext())
            {
                Estate estate = houseContext.Estates.Find(currentEstate.Id);
                houseContext.Estates.Remove(estate);
                houseContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (HouseContext houseContext = new HouseContext())
            {
                List<Estate> prevEstate = houseContext.Estates
                    .Where(estate => estate.Id < currentEstate.Id)
                    .OrderBy(estate => estate.Id)
                    .ToList();

                if (prevEstate.Count > 0)
                {
                    currentEstate = prevEstate.Last();
                    PopulateControls();
                }
                else
                {
                    prevButton.Enabled = false;
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            prevButton.Enabled = true;

            using (HouseContext houseContext = new HouseContext())
            {
                List<Estate> nextEstate = houseContext.Estates
                    .Where(estate => estate.Id > currentEstate.Id)
                    .OrderBy(estate => estate.Id)
                    .ToList();

                if (nextEstate.Count > 0)
                {
                    currentEstate = nextEstate.First();
                    PopulateControls();
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }

        private void PopulateControls()
        {
            adressTextBox.Text = currentEstate.Name;
            priceUpDown.Value = currentEstate.Price;
            categorieComboBox.SelectedValue = currentEstate.Categorie;
            townComboBox.SelectedValue = currentEstate.HouseType;
        }
    }
}
