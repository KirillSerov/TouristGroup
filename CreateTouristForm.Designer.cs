namespace TouristsGroup
{
    partial class CreateTouristForm
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
            this.AddInGroup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.ComboBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddInGroup
            // 
            this.AddInGroup.Location = new System.Drawing.Point(12, 230);
            this.AddInGroup.Name = "AddInGroup";
            this.AddInGroup.Size = new System.Drawing.Size(125, 43);
            this.AddInGroup.TabIndex = 17;
            this.AddInGroup.Text = "Добавить";
            this.AddInGroup.UseVisualStyleBackColor = true;
            this.AddInGroup.Click += new System.EventHandler(this.AddInGroup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Опыт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Имя";
            // 
            // Level
            // 
            this.Level.FormattingEnabled = true;
            this.Level.Location = new System.Drawing.Point(192, 162);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(184, 33);
            this.Level.TabIndex = 12;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(192, 105);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(427, 33);
            this.Surname.TabIndex = 11;
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(192, 58);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(427, 33);
            this.Firstname.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Заполнение группы";
            // 
            // CreateTourist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 311);
            this.Controls.Add(this.AddInGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateTourist";
            this.Text = "CreateTourist";
            this.Load += new System.EventHandler(this.CreateTourist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddInGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Level;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.Label label1;
    }
}