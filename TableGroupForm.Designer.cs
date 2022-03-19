namespace TouristsGroup
{
    partial class TableGroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventar = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AddOrChange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Firstname,
            this.Surname,
            this.Level,
            this.Items,
            this.ItemName,
            this.ItemLevel,
            this.ItemWeight,
            this.Inventar,
            this.AddOrChange,
            this.Delete});
            this.Table.Location = new System.Drawing.Point(12, 35);
            this.Table.Name = "Table";
            this.Table.RowTemplate.Height = 25;
            this.Table.Size = new System.Drawing.Size(1048, 417);
            this.Table.TabIndex = 0;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Имя";
            this.Firstname.Name = "Firstname";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            // 
            // Level
            // 
            this.Level.HeaderText = "Уровень";
            this.Level.Name = "Level";
            // 
            // Items
            // 
            this.Items.HeaderText = "Одежда";
            this.Items.Name = "Items";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Название";
            this.ItemName.Name = "ItemName";
            // 
            // ItemLevel
            // 
            this.ItemLevel.HeaderText = "Уровень";
            this.ItemLevel.Name = "ItemLevel";
            // 
            // ItemWeight
            // 
            this.ItemWeight.HeaderText = "Вес";
            this.ItemWeight.Name = "ItemWeight";
            // 
            // Inventar
            // 
            this.Inventar.HeaderText = "Инвентарь";
            this.Inventar.Name = "Inventar";
            // 
            // AddOrChange
            // 
            this.AddOrChange.HeaderText = "";
            this.AddOrChange.Name = "AddOrChange";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            // 
            // TableGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 479);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableGroupForm";
            this.Text = "TableGroupForm";
            this.Load += new System.EventHandler(this.TableGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewComboBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemWeight;
        private System.Windows.Forms.DataGridViewComboBoxColumn Inventar;
        private System.Windows.Forms.DataGridViewButtonColumn AddOrChange;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}