using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TouristsGroup
{
    public partial class EquipTourist : Form
    {
        Tourist tourist;
        public EquipTourist()
        {
            InitializeComponent();
        }
        public EquipTourist(Tourist tourist)
        {
            InitializeComponent();
            this.tourist = tourist;
        }

        private void FillForm()
        {
            TouristInfo.Text = $"{tourist?.Firstname} {tourist?.Surname}, уровень: {Tourist.LevelString[(int)tourist?.TouristLevel]}";
            if (tourist.Items[0] != null && !string.IsNullOrWhiteSpace(tourist.Items[0].Picture))
            {
                CapPicture.Image = new Bitmap(tourist.Items[0].Picture);
                label5.Visible = false;
                CapDescribe.Text = tourist.Items[0].ShowInfo();
            }
            else
            {
                CapPicture.Image=null;
                label5.Visible = true;
                CapDescribe.Text = "Пусто";
            }
            if (tourist.Items[1] != null && !string.IsNullOrWhiteSpace(tourist.Items[1].Picture))
            {
                JacketPicture.Image = new Bitmap(tourist.Items[1].Picture);
                label6.Visible = false;
                JacketDescribe.Text = tourist.Items[1].ShowInfo();
            }
            else
            {
                JacketPicture.Image = null;
                label6.Visible = true;
                JacketDescribe.Text = "Пусто";
            }
            if (tourist.Items[2] != null && !string.IsNullOrWhiteSpace(tourist.Items[2].Picture))
            {
                ShoesPicture.Image = new Bitmap(tourist.Items[2].Picture);
                label7.Visible = false;
                ShoesDescribe.Text = tourist.Items[2].ShowInfo();
            }
            else
            {
                ShoesPicture.Image = null;
                label7.Visible = true;
                ShoesDescribe.Text = "Пусто";
            }
            if (tourist.Items[3] != null && !string.IsNullOrWhiteSpace(tourist.Items[3].Picture))
            {
                BackpackPicture.Image = new Bitmap(tourist.Items[3].Picture);
                label8.Visible = false;
                OtherItemsButton.Enabled = true;
                BackpackDescribe.Text = tourist.Items[3].ShowInfo();
            }
            else
            {
                BackpackPicture.Image = null;
                label8.Visible = true;
                OtherItemsButton.Enabled = false;
                BackpackDescribe.Text = "Пусто";
            }
        }
        private void ItemSelectForm_Load(object sender, EventArgs e)
        {
            FillForm();
        }
        private void CapPicture_Click(object sender, EventArgs e)
        {
            tourist.Items[0] = new Cap();
            ItemSelect newForm = new ItemSelect(tourist.Items[0]);
            newForm.ShowDialog();
        }

        private void JacketPicture_Click(object sender, EventArgs e)
        {
            tourist.Items[1] = new Jacket();
            ItemSelect newForm = new ItemSelect(tourist.Items[1]);
            newForm.ShowDialog();
        }
        private void ShoesPicture_Click(object sender, EventArgs e)
        {
            tourist.Items[2] = new Shoes();
            ItemSelect newForm = new ItemSelect(tourist.Items[2]);
            newForm.ShowDialog();
        }
        private void BackpackPicture_Click(object sender, EventArgs e)
        {
            tourist.Items[3] = new Backpack();
            ItemSelect newForm = new ItemSelect(tourist.Items[3]);
            newForm.ShowDialog();
        }
        private void ItemSelectForm_Activated(object sender, EventArgs e)
        {
            FillForm();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            // foreach (var item in items)
            //    owener.NewItems = items;
            this.Close();
        }

        private void OtherItemsButton_Click(object sender, EventArgs e)
        {
            OtherItems newForm = new OtherItems(tourist);
            newForm.ShowDialog();
        }
    }
}
