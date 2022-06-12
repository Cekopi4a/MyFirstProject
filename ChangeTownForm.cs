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
    public partial class ChangeTownForm : Form
    {
        private HouseType currentHouseType;
        public ChangeTownForm()
        {
            InitializeComponent();
        }

        private void ChangeTownForm_Load(object sender, EventArgs e)
        {
            using (HouseContext houseContext = new HouseContext())
            {
                currentHouseType = houseContext.HouseTypes
                    .OrderBy(houseType => houseType.Id)
                    .First();
            }

            houseTypeTextBox.Text = currentHouseType.Name;
        }

        private void prevButton_Click_1(object sender, EventArgs e)
        {
        nextButton.Enabled = true;

            using (HouseContext houseContext = new HouseContext())
            {
                List<HouseType> prevHouseTypes = houseContext.HouseTypes
                    .Where(houseType => houseType.Id < currentHouseType.Id)
                    .OrderBy(houseType => houseType.Id)
                    .ToList();

                if (prevHouseTypes.Count > 0)
                {
                    currentHouseType = prevHouseTypes.Last();
                    houseTypeTextBox.Text = currentHouseType.Name;
                }
                else
                {
                    prevButton.Enabled = false;
                }
            }
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            prevButton.Enabled = true;

            using (HouseContext houseContext = new HouseContext())
            {
                List<HouseType> nextHouseTypes = houseContext.HouseTypes
                    .Where(houseType => houseType.Id > currentHouseType.Id)
                    .OrderBy(houseType => houseType.Id)
                    .ToList();

                if (nextHouseTypes.Count > 0)
                {
                    currentHouseType = nextHouseTypes.First();
                    houseTypeTextBox.Text = currentHouseType.Name;
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
                HouseType houseType = new HouseType()
                {
                    Name = houseTypeTextBox.Text
                };

                houseContext.HouseTypes.Add(houseType);
                houseContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            using (HouseContext houseContext = new HouseContext())
            {
                HouseType oldHouseType = houseContext.HouseTypes.Find(currentHouseType.Id);

                HouseType newHouseType = new HouseType()
                {
                    Id = currentHouseType.Id,
                    Name = houseTypeTextBox.Text
                };

                houseContext.Entry(oldHouseType).CurrentValues.SetValues(newHouseType);
                houseContext.SaveChanges();
            }

            nextButton.PerformClick();
        }
    }
}
