namespace Filmography.Views
{
    partial class MovieEmployeeInfoForm
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
            this.ProducedFilm_label = new System.Windows.Forms.Label();
            this.ProducedFilms_listBox = new System.Windows.Forms.ListBox();
            this.Info_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Filmography_label = new System.Windows.Forms.Label();
            this.Filmography_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProducedFilm_label
            // 
            this.ProducedFilm_label.Location = new System.Drawing.Point(327, 73);
            this.ProducedFilm_label.Name = "ProducedFilm_label";
            this.ProducedFilm_label.Size = new System.Drawing.Size(211, 30);
            this.ProducedFilm_label.TabIndex = 11;
            this.ProducedFilm_label.Text = "Спродюсированные фильмы:";
            // 
            // ProducedFilms_listBox
            // 
            this.ProducedFilms_listBox.FormattingEnabled = true;
            this.ProducedFilms_listBox.ItemHeight = 16;
            this.ProducedFilms_listBox.Location = new System.Drawing.Point(327, 106);
            this.ProducedFilms_listBox.Name = "ProducedFilms_listBox";
            this.ProducedFilms_listBox.Size = new System.Drawing.Size(211, 324);
            this.ProducedFilms_listBox.TabIndex = 10;
            // 
            // Info_label
            // 
            this.Info_label.Location = new System.Drawing.Point(45, 106);
            this.Info_label.Name = "Info_label";
            this.Info_label.Size = new System.Drawing.Size(276, 324);
            this.Info_label.TabIndex = 9;
            this.Info_label.Text = "Info";
            // 
            // Name_label
            // 
            this.Name_label.Location = new System.Drawing.Point(45, 43);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(255, 30);
            this.Name_label.TabIndex = 8;
            this.Name_label.Text = "Name";
            // 
            // Filmography_label
            // 
            this.Filmography_label.Location = new System.Drawing.Point(544, 73);
            this.Filmography_label.Name = "Filmography_label";
            this.Filmography_label.Size = new System.Drawing.Size(211, 30);
            this.Filmography_label.TabIndex = 7;
            this.Filmography_label.Text = "Фильмография:";
            // 
            // Filmography_listBox
            // 
            this.Filmography_listBox.FormattingEnabled = true;
            this.Filmography_listBox.ItemHeight = 16;
            this.Filmography_listBox.Location = new System.Drawing.Point(544, 106);
            this.Filmography_listBox.Name = "Filmography_listBox";
            this.Filmography_listBox.Size = new System.Drawing.Size(211, 324);
            this.Filmography_listBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Информация фильма:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фильм:";
            // 
            // MovieEmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProducedFilm_label);
            this.Controls.Add(this.ProducedFilms_listBox);
            this.Controls.Add(this.Info_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Filmography_label);
            this.Controls.Add(this.Filmography_listBox);
            this.Name = "MovieEmployeeInfoForm";
            this.Text = "MovieEmployeeInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProducedFilm_label;
        private System.Windows.Forms.ListBox ProducedFilms_listBox;
        private System.Windows.Forms.Label Info_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Filmography_label;
        private System.Windows.Forms.ListBox Filmography_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}