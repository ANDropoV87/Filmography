namespace Filmography.Views
{
    partial class AdminViewsForm
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
            this.QueryForm_button = new System.Windows.Forms.Button();
            this.AddFilmworker_button = new System.Windows.Forms.Button();
            this.Addfilm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QueryForm_button
            // 
            this.QueryForm_button.Location = new System.Drawing.Point(49, 229);
            this.QueryForm_button.Name = "QueryForm_button";
            this.QueryForm_button.Size = new System.Drawing.Size(268, 68);
            this.QueryForm_button.TabIndex = 9;
            this.QueryForm_button.Text = "Запросы для задания";
            this.QueryForm_button.UseVisualStyleBackColor = true;
            this.QueryForm_button.Click += new System.EventHandler(this.QueryForm_button_Click_1);
            // 
            // AddFilmworker_button
            // 
            this.AddFilmworker_button.Location = new System.Drawing.Point(49, 35);
            this.AddFilmworker_button.Name = "AddFilmworker_button";
            this.AddFilmworker_button.Size = new System.Drawing.Size(268, 67);
            this.AddFilmworker_button.TabIndex = 7;
            this.AddFilmworker_button.Text = "Добавить нового работника киноиндустрии";
            this.AddFilmworker_button.UseVisualStyleBackColor = true;
            this.AddFilmworker_button.Click += new System.EventHandler(this.AddFilmworker_button_Click);
            // 
            // Addfilm_button
            // 
            this.Addfilm_button.Location = new System.Drawing.Point(49, 134);
            this.Addfilm_button.Name = "Addfilm_button";
            this.Addfilm_button.Size = new System.Drawing.Size(268, 68);
            this.Addfilm_button.TabIndex = 6;
            this.Addfilm_button.Text = "Добавить новый фильм";
            this.Addfilm_button.UseVisualStyleBackColor = true;
            this.Addfilm_button.Click += new System.EventHandler(this.Addfilm_button_Click);
            // 
            // AdminViewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 332);
            this.Controls.Add(this.QueryForm_button);
            this.Controls.Add(this.AddFilmworker_button);
            this.Controls.Add(this.Addfilm_button);
            this.Name = "AdminViewsForm";
            this.Text = "AdminViewsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QueryForm_button;
        private System.Windows.Forms.Button AddFilmworker_button;
        private System.Windows.Forms.Button Addfilm_button;
    }
}