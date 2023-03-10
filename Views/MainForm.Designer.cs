namespace Filmography.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Enter_Button = new System.Windows.Forms.Button();
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.Registration_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Watch_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(303, 213);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(177, 50);
            this.Enter_Button.TabIndex = 0;
            this.Enter_Button.Text = "Вход";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // login_TextBox
            // 
            this.login_TextBox.Location = new System.Drawing.Point(252, 138);
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(289, 22);
            this.login_TextBox.TabIndex = 1;
            this.login_TextBox.Text = "Введите Логин";
            this.login_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(250, 175);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(289, 22);
            this.password_TextBox.TabIndex = 2;
            this.password_TextBox.Text = "Введите Пароль";
            this.password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Registration_Button
            // 
            this.Registration_Button.Location = new System.Drawing.Point(303, 270);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.Size = new System.Drawing.Size(177, 37);
            this.Registration_Button.TabIndex = 3;
            this.Registration_Button.Text = "Регистрация";
            this.Registration_Button.UseVisualStyleBackColor = true;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добро пожаловать в Фильмотеку";
            // 
            // Watch_Button
            // 
            this.Watch_Button.Location = new System.Drawing.Point(303, 316);
            this.Watch_Button.Name = "Watch_Button";
            this.Watch_Button.Size = new System.Drawing.Size(177, 53);
            this.Watch_Button.TabIndex = 5;
            this.Watch_Button.Text = "Посмотреть фильмотеку";
            this.Watch_Button.UseVisualStyleBackColor = true;
            this.Watch_Button.Click += new System.EventHandler(this.Watch_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 483);
            this.Controls.Add(this.Watch_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registration_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.login_TextBox);
            this.Controls.Add(this.Enter_Button);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button Registration_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Watch_Button;
    }
}