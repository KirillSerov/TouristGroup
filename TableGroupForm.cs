using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TouristsGroup
{
    public partial class TableGroupForm : Form
    {
        private Group Group { get; }
        public TableGroupForm()
        {
            InitializeComponent();
        }
        public TableGroupForm(Group group)
        {
            InitializeComponent();
            Group = group;

            ToolStripMenuItem fileMenu = new ToolStripMenuItem("Файл");
            ToolStripMenuItem saveMenu = new ToolStripMenuItem("Сохранить");
            saveMenu.Click += SaveMenu_Click;
            fileMenu.DropDownItems.Add(saveMenu);
            menuStrip1.Items.Add(fileMenu);


        }
        private void FillTable()
        {
            Table.Rows.Clear();
            foreach (var tourist in Group.Tourists)
            {
                if (tourist != null)
                {
                    int currentRow = Table.Rows.Add(tourist.Firstname, tourist.Surname, Tourist.LevelString[(int)tourist.TouristLevel]);
                    (Table.Rows[currentRow].Cells[7] as DataGridViewComboBoxCell).Items.AddRange(Group.Tourists[currentRow].Inventar.ToArray());
                    (Table.Rows[currentRow].Cells[8] as DataGridViewButtonCell).Value = "Редактировать";
                    (Table.Rows[currentRow].Cells[9] as DataGridViewButtonCell).Value = "Удалить";
                }
                else if (tourist == null)
                {
                    int currentRow = Table.Rows.Add();
                    (Table.Rows[currentRow].Cells[8] as DataGridViewButtonCell).Value = "Добавить";
                    (Table.Rows[currentRow].Cells[9] as DataGridViewButtonCell).Value = "Удалить";
                }
            }
        }
        private void SaveMenu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Xml files(.xml)|*.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            SaveData save = new SaveData(saveFileDialog1.FileName);
            save.Save(Group);
        }
        private void TableGroupForm_Load(object sender, EventArgs e)
        {
            Table.EditMode = DataGridViewEditMode.EditOnEnter;
            Table.CurrentCellDirtyStateChanged += Table_CurrentCellDirtyStateChanged;
            Table.CellValueChanged += Table_CellValueChanged;
            Table.AllowUserToAddRows = false;

            (Table.Columns[3] as DataGridViewComboBoxColumn).Items.AddRange("Голова", "Тело", "Ноги", "Сумка");
            FillTable();
        }
        private void Table_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (Table.IsCurrentCellDirty)
                Table.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void Table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var rowIdx = e.RowIndex;                                                                                                               // индекс выбранной строки
                var selectedVal = (Table.Rows[rowIdx].Cells[3] as DataGridViewComboBoxCell).Value;                                                     // выбранное значение 
                var selectedItem = Group?.Tourists[rowIdx]?.Items[(Table.Rows[rowIdx].Cells[3] as DataGridViewComboBoxCell).Items.IndexOf(selectedVal)]; // выбранная одежда
                if (selectedItem != null)
                {
                    Table.Rows[rowIdx].Cells[4].Value = selectedItem.Name;
                    Table.Rows[rowIdx].Cells[5].Value = Tourist.LevelString[selectedItem.Level];
                    Table.Rows[rowIdx].Cells[6].Value = selectedItem.Weight;
                }
            }
        }
        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)      // Добавить/редактировать.
            {
                if (Group.Tourists[e.RowIndex] == null)
                {
                    CreateTouristForm addTourist = new CreateTouristForm(Group, e.RowIndex);
                    addTourist.ShowDialog();
                }
                else if (Group.Tourists[e.RowIndex] != null)
                {
                    EquipTourist equip = new EquipTourist(Group.Tourists[e.RowIndex]);
                    equip.Show();
                }
            }
            else if (e.ColumnIndex == 9) // Удалить.
            {
                if (Group.DeleteTourist(e.RowIndex))
                {
                    MessageBox.Show("Турист удалён", "Удаление");
                }                
            }
            FillTable();
        }
    }
}
