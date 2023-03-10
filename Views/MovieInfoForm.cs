using Filmography.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmography.Views
{
    public partial class MovieInfoForm : Form
    {
        Film film;
        MovieEmployeeInfoForm meInfoForm;
        public MovieInfoForm(Film film)
        {
            InitializeComponent();
            this.film = film;
            Actors_listBox.DoubleClick += Actors_listBox_DoubleClick;
            FilmInfoVisual();
        }

        private void Actors_listBox_DoubleClick(object sender, EventArgs e)
        {
            meInfoForm = new MovieEmployeeInfoForm((Actor)Actors_listBox.SelectedItem);
            meInfoForm.ShowDialog();
        }

        private void FilmInfoVisual()
        {
            string country = film.CountryProduce == null ? "???" : film.CountryProduce.Name;
            string producer = film.FilmProduser == null ? "???" : film.FilmProduser.ToString();
            filmName_label.Text = film.Name;
            Info_label.Text = "Жанр:";
            foreach (Genre g in film.Genres)
                Info_label.Text += g.Name + ", ";
            Info_label.Text = $"Год: {film.Year.Year}";
            Info_label.Text += $"\nСтрана производства: {country}\nБюджет: {film.Budget}$\n";
            Info_label.Text += $"Сборы: {film.BoxOffice}$\nКоличество зрителей: {film.Viewers} чел.\n";
            Info_label.Text += $"Страны демонстрации: ";
            foreach (DemoCountry c in film.CountriesDemonstration)
                Info_label.Text += c.Name + ", ";
            Producer_linkLabel.Text = producer;
            film.Actors.ToList().ForEach(a => Actors_listBox.Items.Add(a));
        }
        private void Produser_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (film.FilmProduser != null)
            {
                meInfoForm = new MovieEmployeeInfoForm (film.FilmProduser);
                meInfoForm.ShowDialog();
            }
        }

    }
}
