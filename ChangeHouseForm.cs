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
    public partial class ChangeHouseForm : Form
    {
        private Category currentCat;
        public ChangeHouseForm()
        {
            InitializeComponent();
        }

        private void ChangeHouse_Load(object sender, EventArgs e)
        {
            using (HouseContext houseContext = new HouseContext())
            {
                currentCat = houseContext.Categories
                    .OrderBy(category => category.Id)
                    .First();
            }

            categoryTextBox.Text = currentCat.Name;
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (HouseContext houseContext = new HouseContext())
            {
                List<Category> prevCat = houseContext.Categories
                    .Where(category => category.Id < currentCat.Id)
                    .OrderBy(category => category.Id)
                    .ToList();

                if (prevCat.Count > 0)
                {
                    currentCat = prevCat.Last();
                    categoryTextBox.Text = currentCat.Name;
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
                List<Category> nextCat = houseContext.Categories
                    .Where(category => category.Id > currentCat.Id)
                    .OrderBy(category => category.Id)
                    .ToList();

                if (nextCat.Count > 0)
                {
                    currentCat = nextCat.First();
                    categoryTextBox.Text = currentCat.Name;
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (HouseContext houseContext = new HouseContext())
            {
                Category categorie = new Category()
                {
                    Name = categoryTextBox.Text
                };

                houseContext.Categories.Add(categorie);
                houseContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            using (HouseContext houseContext = new HouseContext())
            {
                Category oldCat = houseContext.Categories.Find(currentCat.Id);

                Category newCat = new Category()
                {
                    Id = currentCat.Id,
                    Name = categoryTextBox.Text
                };

                houseContext.Entry(oldCat).CurrentValues.SetValues(newCat);
                houseContext.SaveChanges();
            }

            nextButton.PerformClick();
        }
    }
}
