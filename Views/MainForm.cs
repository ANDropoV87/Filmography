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
using Filmography.Views;

namespace Filmography.Views
{
    public partial class MainForm : Form
    {
        UserViewsForm userViewsForm;
        AdminViewsForm adminViewsForm;
        RegistartionForm registartionForm;
        DataBaseNew dataBaseNew;


        public MainForm()
        {
            InitializeComponent();
            dataBaseNew = new DataBaseNew();
            this.Load += MainForm_LoadAsync;
        }
        private async void MainForm_LoadAsync(object sender, EventArgs e)
        {
            if ((await dataBaseNew.AddFilmsAndActorsAsync()) == true)
            {
                MessageBox.Show("Фильмы и актёры успешно добавлены в базу данных!");
                Registration_Button.Enabled = true;
                Watch_Button.Enabled = true;
               
                login_TextBox.Enabled = true;
                password_TextBox.Enabled = true;
                label1.Enabled = true;
               
               // Enter_Button.Enabled = true;
               
            }
            else
                MessageBox.Show("Ошибка при загрузке данных!");
        }

        private async void Enter_Button_Click(object sender, EventArgs e)
        {
            User user = await Autorization.Instance.Login (login_TextBox.Text, password_TextBox.Text);
            //
            if (user != null)
            {
                adminViewsForm = new AdminViewsForm();
                adminViewsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверные!");
            }
        }

        private void Watch_Button_Click(object sender, EventArgs e)
        {
            userViewsForm = new UserViewsForm ("Пользователь");
            userViewsForm.ShowDialog();
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            registartionForm = new RegistartionForm();
            registartionForm.ShowDialog();
        }
    }
}
