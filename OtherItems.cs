using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TouristsGroup
{
    public partial class OtherItems : Form
    {
        private Item[] otherItems = new Item[] {
                                    new Water("Вода", 0, 1, @"Pictures\OtherItems\Water.png"),
                                    new CannedFood("Тушёнка",2,1,@"Pictures\OtherItems\CannedFood.png") };
        private Tourist tourist;
        public OtherItems()
        {
            InitializeComponent();
        }

        public OtherItems(Tourist tourist)
        {
            InitializeComponent();
            this.tourist = tourist;
            FillForm();
        }
        private void FillForm()
        {
            CreateItems(otherItems);
            int currentVolume = 0;
            foreach (var item in SelectOtherItems.Controls)
            {
                foreach (var i in tourist.Inventar)
                {
                    if (otherItems[(item as Panel).TabIndex].GetType().Name == i.Item.GetType().Name)
                        ((item as Panel).Controls[2] as Label).Text = i.Count.ToString();

                    int.TryParse(((item as Panel).Controls[3] as TextBox).Text, out int result);
                    currentVolume += result + i.Count;
                }
            }


        }
        private void CreateItems(Item[] items)
        {
            Point startPrint = new Point(10, 10);
            int n = 0;
            SelectOtherItems.Controls.Clear();
            foreach (var item in items)
            {
                Panel panel = new Panel();
                panel.Size = new Size(1000, 70);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(startPrint.X, startPrint.Y + n);

                PictureBox picture = new PictureBox();
                picture.Size = new Size(50, 50);
                picture.Location = new Point(startPrint.X, startPrint.Y);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = new Bitmap(item.Picture);

                Label label = new Label();
                label.Font = new Font(SystemFonts.DefaultFont.Name, 14.25f);
                label.Location = new Point(startPrint.X + 70, startPrint.Y + 10);
                label.AutoSize = true;
                label.Text = item.ShowInfo();

                Label inBackPack = new Label();
                inBackPack.Location = new Point(610, startPrint.Y + 10);
                inBackPack.Width = 50;
                inBackPack.Text = "0";

                TextBox adding = new TextBox();
                adding.Location = new Point(860, startPrint.Y + 10);
                adding.Width = 50;

                panel.Controls.AddRange(new Control[] { picture, label, inBackPack, adding });

                SelectOtherItems.Controls.Add(panel);

                n += 75;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            foreach (var item in SelectOtherItems.Controls)
            {
                int.TryParse(((item as Panel).Controls[3] as TextBox).Text,out int count);
                tourist.AddOtherItem(otherItems[(item as Panel).TabIndex], count);
                this.Close();
            }
        }

       
    }
}
