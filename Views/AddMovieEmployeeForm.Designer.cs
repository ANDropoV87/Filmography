namespace Filmography.Views
{
    partial class AddMovieEmployeeForm
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
            this.addProfButn = new System.Windows.Forms.Button();
            this.CreateFW_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.FinSate_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.City_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Country_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Profession_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Profession_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sex_comboBox = new System.Windows.Forms.ComboBox();
            this.LName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addProfButn
            // 
            this.addProfButn.Location = new System.Drawing.Point(365, 233);
            this.addProfButn.Name = "addProfButn";
            this.addProfButn.Size = new System.Drawing.Size(43, 24);
            this.addProfButn.TabIndex = 37;
            this.addProfButn.Text = "Add";
            this.addProfButn.UseVisualStyleBackColor = true;
            this.addProfButn.Click += new System.EventHandler(this.addProfButn_Click);
            // 
            // CreateFW_button
            // 
            this.CreateFW_button.Location = new System.Drawing.Point(444, 349);
            this.CreateFW_button.Name = "CreateFW_button";
            this.CreateFW_button.Size = new System.Drawing.Size(240, 64);
            this.CreateFW_button.TabIndex = 36;
            this.CreateFW_button.Text = "Добавить нового работника киноиндустрии";
            this.CreateFW_button.UseVisualStyleBackColor = true;
            this.CreateFW_button.Click += new System.EventHandler(this.CreateFW_button_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(441, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Финансовое состояние";
            // 
            // FinSate_maskedTextBox
            // 
            this.FinSate_maskedTextBox.Location = new System.Drawing.Point(444, 174);
            this.FinSate_maskedTextBox.Name = "FinSate_maskedTextBox";
            this.FinSate_maskedTextBox.Size = new System.Drawing.Size(240, 22);
            this.FinSate_maskedTextBox.TabIndex = 34;
            // 
            // City_textBox
            // 
            this.City_textBox.Location = new System.Drawing.Point(444, 112);
            this.City_textBox.Name = "City_textBox";
            this.City_textBox.Size = new System.Drawing.Size(240, 22);
            this.City_textBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(441, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Город";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(441, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Страна ";
            // 
            // Country_comboBox
            // 
            this.Country_comboBox.FormattingEnabled = true;
            this.Country_comboBox.Location = new System.Drawing.Point(444, 48);
            this.Country_comboBox.Name = "Country_comboBox";
            this.Country_comboBox.Size = new System.Drawing.Size(240, 24);
            this.Country_comboBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(116, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 391);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // Profession_listBox
            // 
            this.Profession_listBox.FormattingEnabled = true;
            this.Profession_listBox.ItemHeight = 16;
            this.Profession_listBox.Location = new System.Drawing.Point(119, 281);
            this.Profession_listBox.Name = "Profession_listBox";
            this.Profession_listBox.Size = new System.Drawing.Size(240, 68);
            this.Profession_listBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(116, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Профессия";
            // 
            // Profession_comboBox
            // 
            this.Profession_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Profession_comboBox.FormattingEnabled = true;
            this.Profession_comboBox.Items.AddRange(new object[] {
            "Продюсер",
            "Актёр"});
            this.Profession_comboBox.Location = new System.Drawing.Point(119, 233);
            this.Profession_comboBox.Name = "Profession_comboBox";
            this.Profession_comboBox.Size = new System.Drawing.Size(240, 24);
            this.Profession_comboBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(116, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Пол";
            // 
            // Sex_comboBox
            // 
            this.Sex_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sex_comboBox.FormattingEnabled = true;
            this.Sex_comboBox.Items.AddRange(new object[] {
            "female",
            "male"});
            this.Sex_comboBox.Location = new System.Drawing.Point(119, 169);
            this.Sex_comboBox.Name = "Sex_comboBox";
            this.Sex_comboBox.Size = new System.Drawing.Size(240, 24);
            this.Sex_comboBox.TabIndex = 23;
            // 
            // LName_textBox
            // 
            this.LName_textBox.Location = new System.Drawing.Point(119, 109);
            this.LName_textBox.Name = "LName_textBox";
            this.LName_textBox.Size = new System.Drawing.Size(240, 22);
            this.LName_textBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(116, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Фамилия";
            // 
            // FName_textBox
            // 
            this.FName_textBox.Location = new System.Drawing.Point(119, 48);
            this.FName_textBox.Name = "FName_textBox";
            this.FName_textBox.Size = new System.Drawing.Size(240, 22);
            this.FName_textBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Имя";
            // 
            // AddMovieEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addProfButn);
            this.Controls.Add(this.CreateFW_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FinSate_maskedTextBox);
            this.Controls.Add(this.City_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Country_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Profession_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Profession_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sex_comboBox);
            this.Controls.Add(this.LName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FName_textBox);
            this.Controls.Add(this.label1);
            this.Name = "AddMovieEmployeeForm";
            this.Text = "MovieEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProfButn;
        private System.Windows.Forms.Button CreateFW_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox FinSate_maskedTextBox;
        private System.Windows.Forms.TextBox City_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Country_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox Profession_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Profession_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Sex_comboBox;
        private System.Windows.Forms.TextBox LName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FName_textBox;
        private System.Windows.Forms.Label label1;
    }
}