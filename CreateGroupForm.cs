using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TouristsGroup
{
    public partial class CreateGroupForm : Form
    {
        public Group Group { get; set; }
        public CreateGroupForm()
        {
            InitializeComponent();
            // Создание меню.
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("Файл");
            ToolStripMenuItem loadMenu = new ToolStripMenuItem("Загрузить");
            loadMenu.Click += LoadMenu_Click;
            fileMenu.DropDownItems.Add(loadMenu);
            menuStrip1.Items.Add(fileMenu);
            
            FillForm();
        }
        public void FillForm()
        {
            // Загрузка вариантов групп.
            this.SelectGroupSize.Items.Clear();
            this.SelectGroupSize.Items.Add("Небольшая группа - 3 человека");
            this.SelectGroupSize.Items.Add("Средняя группа - 5 человека");
            this.SelectGroupSize.Items.Add("Большая группа - 7 человека");

            // Отображение кнопки, если группа создана.
            if (Group != null)
                ShowTable.Enabled = true;
            else
                ShowTable.Enabled = false;
        }
        private void LoadMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Xml files (.xml)|*.xml";
            if (file.ShowDialog() == DialogResult.Cancel)
                return;

            LoadData load = new LoadData(file.FileName);
            Group = load.Load();

            if (Group != null)
            {
                TableGroupForm newForm = new TableGroupForm(Group);
                newForm.Show();
            }
        }
        
        private void CreateGroup_Click(object sender, EventArgs e)
        {
            if (this.SelectGroupSize.SelectedItem != null && !string.IsNullOrWhiteSpace(this.GroupName.Text))
            {
                int count;
                switch (SelectGroupSize.SelectedIndex)
                {
                    case (0): count = 3; break;
                    case (1): count = 5; break;
                    case (2): count = 7; break;
                    default: return;
                }
                Group = new Group(GroupName.Text, count);

                // Загрузка форм дял создания туристов.
                for (int i = 0; i < Group.size; i++)
                {
                    CreateTouristForm tmp = new CreateTouristForm(Group, i);
                    tmp.ShowDialog();
                }

                // Отображение группы в таблице.
                TableGroupForm table = new TableGroupForm(Group);
                table.ShowDialog();
            }
        }
        private void ShowTable_Click(object sender, EventArgs e)
        {
            TableGroupForm table = new TableGroupForm(Group);
            table.ShowDialog();
        }
        private void CreateGroupForm_Activated(object sender, EventArgs e)
        {
            FillForm();
        }
    }
}
