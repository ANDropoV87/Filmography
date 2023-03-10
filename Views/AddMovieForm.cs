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
    public partial class AddMovieForm : Form
    {
        MovieEmployeeForm movieEmployeeForm;
        DbNewService dbNewService = DbNewService.Instance;

        public AddMovieForm()
        {
            InitializeComponent();
            Actors_listBox.Click += Actors_listBox_Click;
            Producer_textBox.Click += Producer_textBox_Click;
            numericUpDown1.Value = DateTime.Now.Year;
            this.Load += AddMovieForm_Load;
        }

        private async void AddMovieForm_Load(object sender, EventArgs e)
        {
          //  (await dbNewService.GetCountriesAsync()).ForEach(c => Country_comboBox.Items.Add(c));
         //  (await dbNewService.GetDemoCountriesAsync()).ForEach(c => CountryDemo_comboBox.Items.Add(c));
        }
   
        private async void Producer_textBox_Click(object sender, EventArgs e)
        {
            List<Object> list = (await dbNewService.GetProdusersAsync()).ToList<Object>();
            LoadListBox("Продюсер", Producer_textBox);
        }
        private void LoadListBox(string ProfessionName, Control control)
        {
            movieEmployeeForm = new MovieEmployeeForm(ProfessionName, control);
            movieEmployeeForm.ShowDialog();
        }
        private async void Actors_listBox_Click(object sender, EventArgs e)
        {
            List<Object> list = (await dbNewService.GetActorsAsync()).ToList<Object>();
            LoadListBox("Актёр", Actors_listBox);
        }


        private async Task<Film> FilmCreator()
        {
            Film newFilm = new Film()
            {
                Name = Name_textBox.Text,
                Year = new DateTime((int)numericUpDown1.Value, 1, 1),
                CountryProduce = (CountryMovie)Country_comboBox.SelectedItem ?? new CountryMovie() { Name = Country_comboBox.Name },
                Rating = float.Parse(Rating_maskedTextBox.Text),
                Budget = Decimal.Parse(Budget_maskedTextBox.Text),
                BoxOffice = Decimal.Parse(Budget_maskedTextBox.Text),
                Viewers = Int64.Parse(Viewers_maskedTextBox.Text),
                FilmProduser = (await dbNewService.GetProdusersAsync()).FirstOrDefault(f => f.ToString() == Producer_textBox.Text),
            };
            foreach (Genre g in Genre_listBox.Items)
                newFilm.Genres.Add(g);
            foreach (DemoCountry c in CountryDemo_listBox.Items)
                newFilm.CountriesDemonstration.Add(c);
            foreach (Actor f in Actors_listBox.Items)
                newFilm.Actors.Add(f);
            return newFilm;
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            Film newFilm = await FilmCreator();
            newFilm.Genres.ToList().ForEach(g => g.Films.Add(newFilm));
            newFilm.CountryProduce.FilmProduce.Add(newFilm);
           newFilm.CountriesDemonstration.ToList().ForEach(c => c.Films.Add(newFilm));
            newFilm.Actors.ToList().ForEach(a => a.MovieLibrary.Add(newFilm));
            await dbNewService.InsertToDbAsync(newFilm);
            this.Close();
        }

        private async void AddGenre_button_Click(object sender, EventArgs e)
        {
            Genre genre = (await dbNewService.GetGenresAsync()).FirstOrDefault(g => g.Name == Genre_comboBox.Text) ?? new Genre() { Name = Genre_comboBox.Text };
            foreach (Genre g in Genre_listBox.Items)
            {
                if (g.Name == genre.Name)
                    return;
            }
            if (Genre_comboBox.Text != "")
                Genre_listBox.Items.Add(genre);
        }
        private async void AddCountryDemo_button_Click(object sender, EventArgs e)
        {
            CountryMovie countrymovie = (await dbNewService.GetCountriesAsync()).FirstOrDefault(c => c.Name == CountryDemo_comboBox.Text) ?? new CountryMovie() { Name = CountryDemo_comboBox.Text };
            if (countrymovie.Name != "")
                CountryDemo_listBox.Items.Add(countrymovie);
        }

        private void CountryDemo_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
