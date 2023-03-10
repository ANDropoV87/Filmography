using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filmography.Models;

namespace Filmography.Views
{
    public partial class RegistartionForm : Form
    {
        Autorization autorization;
        public RegistartionForm()
        {

            InitializeComponent();
            autorization = Autorization.Instance;
        }


        private async void CreateAccount_Button_Click(object sender, EventArgs e)
        {
            if (await autorization.GetUser(LoginR_TextBox.Text) != null)
            {
                MessageBox.Show("Аккаунт с таким логином уже существует!");
                return;
            }
            if (Password1_TextBox.Text != Password2_TextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }
            User user = new User() { Login = LoginR_TextBox.Text, Password = Password1_TextBox.Text };
            if (await autorization.CreateUser(user) == true)
            {
                MessageBox.Show("Регистрация прошла успешно!");
                this.Close();
            }
        }
    }
}
