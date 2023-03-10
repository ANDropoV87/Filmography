namespace Filmography.Views
{
    partial class RegistartionForm
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
            this.LoginR_TextBox = new System.Windows.Forms.TextBox();
            this.Password1_TextBox = new System.Windows.Forms.TextBox();
            this.Password2_TextBox = new System.Windows.Forms.TextBox();
            this.CreateAccount_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginR_TextBox
            // 
            this.LoginR_TextBox.Location = new System.Drawing.Point(98, 131);
            this.LoginR_TextBox.Name = "LoginR_TextBox";
            this.LoginR_TextBox.Size = new System.Drawing.Size(213, 22);
            this.LoginR_TextBox.TabIndex = 0;
            this.LoginR_TextBox.Text = "Логин";
            this.LoginR_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password1_TextBox
            // 
            this.Password1_TextBox.Location = new System.Drawing.Point(98, 187);
            this.Password1_TextBox.Name = "Password1_TextBox";
            this.Password1_TextBox.Size = new System.Drawing.Size(213, 22);
            this.Password1_TextBox.TabIndex = 1;
            this.Password1_TextBox.Text = "Пароль";
            this.Password1_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password2_TextBox
            // 
            this.Password2_TextBox.Location = new System.Drawing.Point(98, 241);
            this.Password2_TextBox.Name = "Password2_TextBox";
            this.Password2_TextBox.Size = new System.Drawing.Size(213, 22);
            this.Password2_TextBox.TabIndex = 2;
            this.Password2_TextBox.Text = "Повторите пароль";
            this.Password2_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateAccount_Button
            // 
            this.CreateAccount_Button.Location = new System.Drawing.Point(99, 300);
            this.CreateAccount_Button.Name = "CreateAccount_Button";
            this.CreateAccount_Button.Size = new System.Drawing.Size(212, 42);
            this.CreateAccount_Button.TabIndex = 3;
            this.CreateAccount_Button.Text = "Создать аккаунт";
            this.CreateAccount_Button.UseVisualStyleBackColor = true;
            this.CreateAccount_Button.Click += new System.EventHandler(this.CreateAccount_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Регистрация";
            // 
            // RegistartionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateAccount_Button);
            this.Controls.Add(this.Password2_TextBox);
            this.Controls.Add(this.Password1_TextBox);
            this.Controls.Add(this.LoginR_TextBox);
            this.Name = "RegistartionForm";
            this.Text = "RegistartionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginR_TextBox;
        private System.Windows.Forms.TextBox Password1_TextBox;
        private System.Windows.Forms.TextBox Password2_TextBox;
        private System.Windows.Forms.Button CreateAccount_Button;
        private System.Windows.Forms.Label label1;
    }
}