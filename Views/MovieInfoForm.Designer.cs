namespace Filmography.Views
{
    partial class MovieInfoForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.Actors_listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Producer_linkLabel = new System.Windows.Forms.LinkLabel();
            this.Info_label = new System.Windows.Forms.Label();
            this.filmName_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(449, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Актёры:";
            // 
            // Actors_listBox
            // 
            this.Actors_listBox.FormattingEnabled = true;
            this.Actors_listBox.ItemHeight = 16;
            this.Actors_listBox.Location = new System.Drawing.Point(452, 185);
            this.Actors_listBox.Name = "Actors_listBox";
            this.Actors_listBox.Size = new System.Drawing.Size(238, 276);
            this.Actors_listBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(449, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Продюсер: ";
            // 
            // Producer_linkLabel
            // 
            this.Producer_linkLabel.Location = new System.Drawing.Point(547, 104);
            this.Producer_linkLabel.Name = "Producer_linkLabel";
            this.Producer_linkLabel.Size = new System.Drawing.Size(268, 28);
            this.Producer_linkLabel.TabIndex = 8;
            this.Producer_linkLabel.TabStop = true;
            this.Producer_linkLabel.Text = "linkLabel1";
            // 
            // Info_label
            // 
            this.Info_label.Location = new System.Drawing.Point(39, 104);
            this.Info_label.Name = "Info_label";
            this.Info_label.Size = new System.Drawing.Size(332, 357);
            this.Info_label.TabIndex = 7;
            this.Info_label.Text = "Info_label";
            // 
            // filmName_label
            // 
            this.filmName_label.Location = new System.Drawing.Point(191, 43);
            this.filmName_label.Name = "filmName_label";
            this.filmName_label.Size = new System.Drawing.Size(457, 38);
            this.filmName_label.TabIndex = 6;
            this.filmName_label.Text = "Film_name";
            this.filmName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название фильма";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(39, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Информация";
            // 
            // MovieInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Actors_listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Producer_linkLabel);
            this.Controls.Add(this.Info_label);
            this.Controls.Add(this.filmName_label);
            this.Name = "MovieInfoForm";
            this.Text = "MovieInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Actors_listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Producer_linkLabel;
        private System.Windows.Forms.Label Info_label;
        private System.Windows.Forms.Label filmName_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}