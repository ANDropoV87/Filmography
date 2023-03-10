namespace Filmography.Views
{
    partial class AddMovieForm
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
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Actors_listBox = new System.Windows.Forms.ListBox();
            this.Genre_listBox = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Producer_textBox = new System.Windows.Forms.TextBox();
            this.Genre_comboBox = new System.Windows.Forms.ComboBox();
            this.AddGenre_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Rating_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Budget_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BoxOffice_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Viewers_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CountryDemo_listBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddCountryDemo_button = new System.Windows.Forms.Button();
            this.CountryDemo_comboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Country_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(31, 56);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(144, 22);
            this.Name_textBox.TabIndex = 0;
            // 
            // Actors_listBox
            // 
            this.Actors_listBox.FormattingEnabled = true;
            this.Actors_listBox.ItemHeight = 16;
            this.Actors_listBox.Location = new System.Drawing.Point(29, 240);
            this.Actors_listBox.Name = "Actors_listBox";
            this.Actors_listBox.Size = new System.Drawing.Size(258, 196);
            this.Actors_listBox.TabIndex = 8;
            // 
            // Genre_listBox
            // 
            this.Genre_listBox.FormattingEnabled = true;
            this.Genre_listBox.ItemHeight = 16;
            this.Genre_listBox.Location = new System.Drawing.Point(320, 224);
            this.Genre_listBox.Name = "Genre_listBox";
            this.Genre_listBox.Size = new System.Drawing.Size(232, 212);
            this.Genre_listBox.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(330, 57);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1910,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(186, 22);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1910,
            0,
            0,
            0});
            // 
            // Producer_textBox
            // 
            this.Producer_textBox.Location = new System.Drawing.Point(28, 184);
            this.Producer_textBox.Name = "Producer_textBox";
            this.Producer_textBox.Size = new System.Drawing.Size(258, 22);
            this.Producer_textBox.TabIndex = 11;
            // 
            // Genre_comboBox
            // 
            this.Genre_comboBox.FormattingEnabled = true;
            this.Genre_comboBox.Items.AddRange(new object[] {
            "Мелодрама",
            "Документальный",
            "Приключение",
            "Биография",
            "Фантастика",
            "Мультфильм",
            "Фэнтези",
            "Боевик",
            "Ужас",
            "Триллер",
            "Драма",
            "Комедия",
            ""});
            this.Genre_comboBox.Location = new System.Drawing.Point(320, 184);
            this.Genre_comboBox.Name = "Genre_comboBox";
            this.Genre_comboBox.Size = new System.Drawing.Size(143, 24);
            this.Genre_comboBox.TabIndex = 12;
            // 
            // AddGenre_button
            // 
            this.AddGenre_button.Location = new System.Drawing.Point(469, 175);
            this.AddGenre_button.Name = "AddGenre_button";
            this.AddGenre_button.Size = new System.Drawing.Size(96, 40);
            this.AddGenre_button.TabIndex = 13;
            this.AddGenre_button.Text = "Добавить жанр";
            this.AddGenre_button.UseVisualStyleBackColor = true;
            this.AddGenre_button.Click += new System.EventHandler(this.AddGenre_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название фильма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(331, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Рейтинг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(207, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Бюджет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(378, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Сборы фильма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(558, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Количестов зрителей";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(306, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Добавить фильм";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(29, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(759, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Добавить фильм";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rating_maskedTextBox
            // 
            this.Rating_maskedTextBox.Location = new System.Drawing.Point(32, 120);
            this.Rating_maskedTextBox.Name = "Rating_maskedTextBox";
            this.Rating_maskedTextBox.Size = new System.Drawing.Size(146, 22);
            this.Rating_maskedTextBox.TabIndex = 23;
            this.Rating_maskedTextBox.Text = "0";
            // 
            // Budget_maskedTextBox
            // 
            this.Budget_maskedTextBox.Location = new System.Drawing.Point(195, 120);
            this.Budget_maskedTextBox.Name = "Budget_maskedTextBox";
            this.Budget_maskedTextBox.Size = new System.Drawing.Size(146, 22);
            this.Budget_maskedTextBox.TabIndex = 24;
            this.Budget_maskedTextBox.Text = "0";
            // 
            // BoxOffice_maskedTextBox
            // 
            this.BoxOffice_maskedTextBox.Location = new System.Drawing.Point(381, 120);
            this.BoxOffice_maskedTextBox.Name = "BoxOffice_maskedTextBox";
            this.BoxOffice_maskedTextBox.Size = new System.Drawing.Size(146, 22);
            this.BoxOffice_maskedTextBox.TabIndex = 25;
            this.BoxOffice_maskedTextBox.Text = "0";
            // 
            // Viewers_maskedTextBox
            // 
            this.Viewers_maskedTextBox.Location = new System.Drawing.Point(562, 120);
            this.Viewers_maskedTextBox.Name = "Viewers_maskedTextBox";
            this.Viewers_maskedTextBox.Size = new System.Drawing.Size(146, 22);
            this.Viewers_maskedTextBox.TabIndex = 26;
            this.Viewers_maskedTextBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(34, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Продюсер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(326, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Жанр";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(29, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Актеры";
            // 
            // CountryDemo_listBox
            // 
            this.CountryDemo_listBox.FormattingEnabled = true;
            this.CountryDemo_listBox.ItemHeight = 16;
            this.CountryDemo_listBox.Location = new System.Drawing.Point(561, 224);
            this.CountryDemo_listBox.Name = "CountryDemo_listBox";
            this.CountryDemo_listBox.Size = new System.Drawing.Size(227, 212);
            this.CountryDemo_listBox.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(531, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 33;
            // 
            // AddCountryDemo_button
            // 
            this.AddCountryDemo_button.Location = new System.Drawing.Point(744, 176);
            this.AddCountryDemo_button.Name = "AddCountryDemo_button";
            this.AddCountryDemo_button.Size = new System.Drawing.Size(96, 40);
            this.AddCountryDemo_button.TabIndex = 32;
            this.AddCountryDemo_button.Text = "Добавить страну";
            this.AddCountryDemo_button.UseVisualStyleBackColor = true;
            this.AddCountryDemo_button.Click += new System.EventHandler(this.AddCountryDemo_button_Click);
            // 
            // CountryDemo_comboBox
            // 
            this.CountryDemo_comboBox.FormattingEnabled = true;
            this.CountryDemo_comboBox.Items.AddRange(new object[] {
            "Россия",
            "Индия",
            "Германия",
            "Франция",
            "Китай",
            "Япония",
            "США",
            "Англия"});
            this.CountryDemo_comboBox.Location = new System.Drawing.Point(584, 182);
            this.CountryDemo_comboBox.Name = "CountryDemo_comboBox";
            this.CountryDemo_comboBox.Size = new System.Drawing.Size(154, 24);
            this.CountryDemo_comboBox.TabIndex = 31;
            this.CountryDemo_comboBox.SelectedIndexChanged += new System.EventHandler(this.CountryDemo_comboBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(568, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Демонстрационные страны";
            // 
            // Country_comboBox
            // 
            this.Country_comboBox.FormattingEnabled = true;
            this.Country_comboBox.Items.AddRange(new object[] {
            "Россия",
            "Индия",
            "Германия",
            "Франция",
            "Китай",
            "Япония",
            "США",
            "Англия"});
            this.Country_comboBox.Location = new System.Drawing.Point(593, 54);
            this.Country_comboBox.Name = "Country_comboBox";
            this.Country_comboBox.Size = new System.Drawing.Size(173, 24);
            this.Country_comboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(590, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Страна производитель";
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 500);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AddCountryDemo_button);
            this.Controls.Add(this.CountryDemo_comboBox);
            this.Controls.Add(this.CountryDemo_listBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Viewers_maskedTextBox);
            this.Controls.Add(this.BoxOffice_maskedTextBox);
            this.Controls.Add(this.Budget_maskedTextBox);
            this.Controls.Add(this.Rating_maskedTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddGenre_button);
            this.Controls.Add(this.Genre_comboBox);
            this.Controls.Add(this.Producer_textBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Genre_listBox);
            this.Controls.Add(this.Actors_listBox);
            this.Controls.Add(this.Country_comboBox);
            this.Controls.Add(this.Name_textBox);
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            this.Load += new System.EventHandler(this.AddMovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.ListBox Actors_listBox;
        private System.Windows.Forms.ListBox Genre_listBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox Producer_textBox;
        private System.Windows.Forms.ComboBox Genre_comboBox;
        private System.Windows.Forms.Button AddGenre_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox Rating_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox Budget_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox BoxOffice_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox Viewers_maskedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox CountryDemo_listBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddCountryDemo_button;
        private System.Windows.Forms.ComboBox CountryDemo_comboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Country_comboBox;
        private System.Windows.Forms.Label label3;
    }
}