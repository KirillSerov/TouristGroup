using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TouristsGroup
{
    public partial class CreateTouristForm : Form
    {
        private Group Group { get; }
        private int index;
        public CreateTouristForm()
        {
            InitializeComponent();
        }
        public CreateTouristForm(Group group, int index)
        {
            if (index < 0 || index > group.size)
                return;
            InitializeComponent();
            
            Group = group;
            this.index = index;
        }

        private void CreateTourist_Load(object sender, EventArgs e)
        {
            this.Level.Items.AddRange(Tourist.LevelString);
        }

        private void AddInGroup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Firstname.Text) && !string.IsNullOrWhiteSpace(Surname.Text) && Level.SelectedItem != null)
            {
                Group.AddTourist(new Tourist(Firstname.Text, Surname.Text, (Tourist.Level)Level.SelectedIndex), index);
                this.Close();
            }
        }
    }
}
