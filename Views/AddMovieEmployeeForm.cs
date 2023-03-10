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
    public partial class AddMovieEmployeeForm : Form
    {
        DbNewService dbNewService = DbNewService.Instance;
        public AddMovieEmployeeForm()
        {
            InitializeComponent();
            this.Load += AddMovieEmployeeForm_LoadAsync;
        }
        private async void AddMovieEmployeeForm_LoadAsync(object sender, EventArgs e)
        {
            (await dbNewService.GetCountriesAsync()).ForEach((c) => Country_comboBox.Items.Add(c));
            Sex_comboBox.SelectedIndex = 1;
        }
        private async Task<bool> MovieEmployeeCreatorAsync(string ProfessionName)
        {
            MovieEmployee employee = null;
            try
            {
                switch (ProfessionName)
                {
                    case "Продюсер":
                        employee = new Produser();
                        break;
                    case "Актёр":
                        employee = new Actor();
                        break;
                    default: break;
                }
                employee.FirstName = FName_textBox.Text;
                employee.LastName = LName_textBox.Text;
                employee.Sex = Sex_comboBox.Text;
                employee.Birthday = dateTimePicker1.Value.Date;
                employee.City = City_textBox.Text;
                employee.FinState = Decimal.Parse(FinSate_maskedTextBox.Text);
                employee.Nation = (await dbNewService.GetCountriesAsync()).FirstOrDefault(c => c.Name == Country_comboBox.Text) ?? new CountryMovie() { Name = Country_comboBox.Text };
                switch (ProfessionName)
                {
                    case "Продюсер":
                        await dbNewService.InsertToDbAsync((Produser)employee);
                        break;
                    case "Актёр":
                        await dbNewService.InsertToDbAsync((Actor)employee);
                        break;
                    default: break;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private async void CreateFW_button_Click(object sender, EventArgs e)
        {
            foreach (string profName in Profession_comboBox.Items)
            {
                if (await MovieEmployeeCreatorAsync(profName) == true)
                    MessageBox.Show($"Новый {profName.ToLower()} успешно добавлен в базу данных");
            }
            this.Close();
        }

        private void addProfButn_Click(object sender, EventArgs e)
        {
            if (Profession_listBox.Items.Contains(Profession_comboBox.Text) == false)
                Profession_listBox.Items.Add(Profession_comboBox.Text);
        }
    }
}
