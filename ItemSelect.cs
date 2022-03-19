using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TouristsGroup
{
    public partial class ItemSelect : Form
    {
        private Item[] items;
        private Item item;

        public ItemSelect()
        {
            InitializeComponent();
        }

        public ItemSelect(Item item)
        {
            InitializeComponent();
            this.item = item;
        }
        private void FillForm()
        {
            Cap[] caps = new Cap[]
            {
                new Cap("Кепка",0,1,@"Pictures\Items\Cap\Cap.png"),
                new Cap("Шапка",1,2,@"Pictures\Items\Cap\Hat.png"),
                new Cap("Шлем",2,3,@"Pictures\Items\Cap\Helmet.png"),
            };

            Jacket[] jackets = new Jacket[]
            {
                new Jacket("Майка",0,1,@"Pictures\Items\Jacket\T-Shirt.png"),
                new Jacket("Свитер",1,2,@"Pictures\Items\Jacket\Pullover.png"),
                new Jacket("Куртка",2,3,@"Pictures\Items\Jacket\Jacket.png"),
            };

            Shoes[] shoes = new Shoes[]
            {
                new Shoes("Тапки",0,1,@"Pictures\Items\Shoes\Slipper.png"),
                new Shoes("Кроссовки",1,2,@"Pictures\Items\Shoes\Snickers.png"),
                new Shoes("Ботинки",2,3,@"Pictures\Items\Shoes\Shoe.png"),
            };

            Backpack[] backpacks = new Backpack[]
            {
                new Backpack("Пакет",0,1,@"Pictures\Items\Backpack\PaperBag.png",5),
                new Backpack("Сумка",1,2,@"Pictures\Items\Backpack\Bag.png",15),
                new Backpack("Походный рюкзак",2,3,@"Pictures\Items\Backpack\Backpack.png",25),
            };
            if (item is Cap)
            {
                items = caps;
                CreateItems(items);
            }
            else if (item is Jacket)
            {
                items = jackets;
                CreateItems(items);
            }
            else if (item is Shoes)
            {
                items = shoes;
                CreateItems(items);
            }
            else if (item is Backpack)
            {
                items = backpacks;
                CreateItems(items);
            }
            else return;
        }

        private void ItemSelect_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void CreateItems(Item[] items)
        {
            Point startPrint = new Point(10, 10);
            int n = 0;

            foreach (Item item in items)
            {
                Panel panel = new Panel();
                panel.Size = new Size(500, 70);
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
                label.Enabled = false;
                label.Text = item.ShowInfo();

                panel.Controls.Add(picture);
                panel.Controls.Add(label);

                panel1.Controls.Add(panel);
                panel.MouseEnter += Panel_MouseEnter;
                panel.MouseLeave += Panel_MouseLeave;
                panel.MouseDown += Panel_MouseDown;
                panel.MouseUp += Panel_MouseUp;
                panel.Click += Panel_Click;
                n += 75;
            }
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            int tmp = (sender as Panel).TabIndex;
            items[tmp].Copy(item);
            this.Close();
        }

        #region Изменение цвета при взаимодействии с Panel
        private static Color stockColor; // Сюда поместим изначальный цвет Panel
        private static void Panel_MouseEnter(object sender, EventArgs e)
        {
            stockColor = (sender as Panel).BackColor;
            (sender as Panel).BackColor = Color.FromArgb(34, 139, 34);
        }
        private static void Panel_MouseLeave(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = stockColor;
        }

        private static Color stockBeforePush; // Сюда поместим цвет Panel до нажатия
        private static void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            stockBeforePush = (sender as Panel).BackColor;
            (sender as Panel).BackColor = Color.FromArgb(0, 128, 0);
        }
        private static void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Panel).BackColor = stockBeforePush;
        }

        
        #endregion

    }
}
