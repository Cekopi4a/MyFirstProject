using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace House_Project2
{
    public partial class chouseHouse : Form
    {
        private string filter = "categories";

        public chouseHouse()
        {
            InitializeComponent();
        }
        
        private void chouseHouse_Load(object sender, EventArgs e)
        {
            List<Category> category;
            List<HouseType> houseTypes;

            using (HouseContext houseContext = new HouseContext())
            {
                category = houseContext.Categories.OrderBy(category1 => category1.Id).ToList();
                houseTypes = houseContext.HouseTypes.OrderBy(houseTypes1 => houseTypes1.Id).ToList();
            }

            CatComboBox.ValueMember = "Id";
            CatComboBox.DisplayMember = "Name";
            CatComboBox.DataSource = category;

            TownComboBox.ValueMember = "Id";
            TownComboBox.DisplayMember = "Name";
            TownComboBox.DataSource = houseTypes;

            filtersButton.BackgroundImage = filter == "categories" || filter == "houseType"
                ? Properties.Resources.unlocked
                : Properties.Resources.locked;
              
        }

        private void CatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter != "categories & houseType")
            {
                filter = "categories";
            }

            ApplyFilters();
        }

        private void TownComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter != "categories & houseType")
            {
                filter = "houseType";
            }

            ApplyFilters();
        }

        private void filtersButton_Click(object sender, EventArgs e)
        {
            if (filter == "categories" || filter == "houseType")
            {
                filter = "categories & houseType";
            }
            else
            {
                filter = "categories";
            }

            filtersButton.BackgroundImage = filter == "categories" || filter == "houseType"
                ? Properties.Resources.unlocked
                : Properties.Resources.locked;
                
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            int categoriesId;
            int houseTypeId;
            List<Estate> filteredEstate = null;

            using (HouseContext houseContext = new HouseContext())
            {
                if (filter == "categories & houseType")
                {
                    categoriesId = (int)CatComboBox.SelectedValue;
                    houseTypeId = (int)TownComboBox.SelectedValue;

                    filteredEstate = houseContext.Estates
                        .Where(estate => estate.Categorie == categoriesId && estate.HouseType == houseTypeId)
                        .ToList();
                }
                else
                {
                    if (filter == "categories")
                    {
                        categoriesId = (int)CatComboBox.SelectedValue;

                        filteredEstate = houseContext.Estates
                        .Where(estate => estate.Categorie == categoriesId)
                        .ToList();
                    }
                    else if (filter == "houseType")
                    {
                        houseTypeId = (int)TownComboBox.SelectedValue;

                        filteredEstate = houseContext.Estates
                        .Where(estate => estate.HouseType == houseTypeId)
                        .ToList();
                    }
                }

                PopulateListView(filteredEstate);
            }
        }

        private void PopulateListView(List<Estate> estates)
        {
            ImageList imageListSmall = new ImageList();
            imageListSmall.ImageSize = new Size(200, 100);

            houseListView.Items.Clear();

            for (int index = 0; index < estates.Count; index++)
            {
                Estate estate = estates[index];

                string[] rowData = new string[]
                {
                    estate.Category.Name,
                    estate.Name,
                    estate.HouseType1.Name,
                    estate.Price.ToString() + " лв."
                };

                ListViewItem item = new ListViewItem(rowData);
                item.ImageIndex = index;
                houseListView.Items.Add(item);

                Image image = Bitmap.FromFile($"..\\..\\Images\\{estate.Name}.jpg");
                imageListSmall.Images.Add(image);
            }

            houseListView.SmallImageList = imageListSmall;
        }
    }
}
