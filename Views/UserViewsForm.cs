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
    public partial class UserViewsForm : Form
    {
        DbNewService service;
        MovieInfoForm filmInfoForm;
        List<Film> filmList;
        string userStatus = null;

        public UserViewsForm(string userStatus)
        {
            InitializeComponent();
            this.userStatus = userStatus;
            //if (userStatus == "Администратор")
            ExtraButtonLoad();
            service = DbNewService.Instance;
            filmList = new List<Film>();
            this.Load += UserForm_LoadAsync;
            Films_listBox.DoubleClick += Films_listBox_DoubleClick;
            Genre_listBox.DoubleClick += Genre_listBox_DoubleClick;
            Actor_listBox.DoubleClick += Actor_listBox_DoubleClick;
            DemoCountries_listBox.DoubleClick += DemoCountries_listBox_DoubleClick;
            Genre_comboBox.SelectedIndex = 0;
            Actor_comboBox.SelectedIndex = 0;
            Producer_comboBox.SelectedIndex = 0;
            Country_comboBox.SelectedIndex = 0;
            Sorting_comboBox.SelectedIndex = 0;
            DemoCountry_comboBox.SelectedIndex = 0;
        }

       
        private void ExtraButtonLoad()
        {
            DeleteFilm_button.Enabled = true;
            DeleteFilm_button.Visible = true;
        }
        private void DemoCountries_listBox_DoubleClick(object sender, EventArgs e)
        {
            DemoCountries_listBox.Items.Remove(DemoCountries_listBox.SelectedItem);
            UpdateListBox(AllLimits(filmList));
        }

        private void Films_listBox_DoubleClick(object sender, EventArgs e)
        {
            filmInfoForm = new MovieInfoForm((Film)Films_listBox.SelectedItem);
            filmInfoForm.ShowDialog();
        }

        private void Actor_listBox_DoubleClick(object sender, EventArgs e)
        {
            Actor_listBox.Items.Remove(Actor_listBox.SelectedItem);
            UpdateListBox(AllLimits(filmList));
        }

        private void Genre_listBox_DoubleClick(object sender, EventArgs e)
        {
            Genre_listBox.Items.Remove(Genre_listBox.SelectedItem);
            UpdateListBox(AllLimits(filmList));
        }
        private async void UserForm_LoadAsync(object sender, EventArgs e)
        {
            (await service.GetFilmsAsync()).ForEach(f => filmList.Add(f));

            (await service.GetGenresAsync()).ForEach(g => Genre_comboBox.Items.Add(g));
            (await service.GetActorsAsync()).ToList().ForEach(f => Actor_comboBox.Items.Add(f));
            (await service.GetProdusersAsync()).ToList().ForEach(f => Producer_comboBox.Items.Add(f));
            (await service.GetCountriesAsync()).ForEach(c => Country_comboBox.Items.Add(c));
            (await service.GetDemoCountriesAsync()).ForEach(c => DemoCountry_comboBox.Items.Add(c));

            Rating1_numericUpDown.Maximum = (await service.GetFilmsAsync()).Max(f => (decimal)(f.Rating));
            Rating1_numericUpDown.Minimum = (await service.GetFilmsAsync()).Min(f => (decimal)(f.Rating));
            Rating1_numericUpDown.Value = Rating1_numericUpDown.Minimum;
            Rating2_numericUpDown.Maximum = Rating1_numericUpDown.Maximum;
            Rating2_numericUpDown.Minimum = Rating1_numericUpDown.Minimum;
            Rating2_numericUpDown.Value = Rating2_numericUpDown.Maximum;

            Year1_numericUpDown.Maximum = (await service.GetFilmsAsync()).Max(f => (decimal)(f.Year.Year));
            Year1_numericUpDown.Minimum = (await service.GetFilmsAsync()).Min(f => (decimal)(f.Year.Year));
            Year1_numericUpDown.Value = Year1_numericUpDown.Minimum;
            Year2_numericUpDown.Maximum = Year1_numericUpDown.Maximum;
            Year2_numericUpDown.Minimum = Year1_numericUpDown.Minimum;
            Year2_numericUpDown.Value = Year2_numericUpDown.Maximum;

            Budget1_numericUpDown.Maximum = (await service.GetFilmsAsync()).Max(f => (decimal)(f.Budget));
            Budget1_numericUpDown.Minimum = (await service.GetFilmsAsync()).Min(f => (decimal)(f.Budget));
            Budget1_numericUpDown.Value = Budget1_numericUpDown.Minimum;
            Budget2_numericUpDown.Maximum = Budget1_numericUpDown.Maximum;
            Budget2_numericUpDown.Minimum = Budget1_numericUpDown.Minimum;
            Budget2_numericUpDown.Value = Budget2_numericUpDown.Maximum;

            Box1_numericUpDown.Maximum = (await service.GetFilmsAsync()).Max(f => (decimal)(f.BoxOffice));
            Box1_numericUpDown.Minimum = (await service.GetFilmsAsync()).Min(f => (decimal)(f.BoxOffice));
            Box1_numericUpDown.Value = Box1_numericUpDown.Minimum;
            Box2_numericUpDown.Maximum = Box1_numericUpDown.Maximum;
            Box2_numericUpDown.Minimum = Box1_numericUpDown.Minimum;
            Box2_numericUpDown.Value = Box2_numericUpDown.Maximum;

            Genre_comboBox.SelectedIndexChanged += Genre_comboBox_SelectedIndexChanged;
            Actor_comboBox.SelectedIndexChanged += Actor_comboBox_SelectedIndexChanged;
            Producer_comboBox.SelectedIndexChanged += Producer_comboBox_SelectedIndexChanged;
            Country_comboBox.SelectedIndexChanged += Country_comboBox_SelectedIndexChanged;
            Sorting_comboBox.SelectedIndexChanged += Sorting_comboBox_SelectedIndexChanged;
            DemoCountry_comboBox.SelectedIndexChanged += DemoCountry_comboBox_SelectedIndexChanged;
        }

        private void DemoCountry_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DemoCountry_comboBox.SelectedIndex == 0)
            {
                DemoCountries_listBox.Items.Clear();
                UpdateListBox(AllLimits(filmList));
                return;
            }
            DemoCountries_listBox.Items.Add(DemoCountry_comboBox.SelectedItem);
            UpdateListBox(AllLimits(filmList));
        }

        private void UpdateListBox(List<Film> films)
        {
            Films_listBox.Items.Clear();
            films.ForEach(f => Films_listBox.Items.Add(f));
        }

        public List<Film> SortingFilms(int sortingTypeIndex)
        {
            switch (sortingTypeIndex)
            {
                case 0: return filmList.OrderBy(f => f.Name).ToList();
                case 1: return filmList.OrderBy(f => f.Year).ToList();
                case 2: return filmList.OrderBy(f => f.Budget).ToList();
                case 3: return filmList.OrderBy(f => f.BoxOffice).ToList();
                case 4: return filmList.OrderBy(f => f.CountryProduce).ToList();
                default: return filmList.OrderBy(f => f.Name).ToList();
            }
        }
        private void Sorting_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Film> films = SortingFilms(Sorting_comboBox.SelectedIndex);
            UpdateListBox(AllLimits(films));
            Reverse_button.Text = "↑";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reverse_button.Text = Reverse_button.Text == "↑" ? "↓" : "↑";
            List<Film> films = new List<Film>();
            foreach (Film item in Films_listBox.Items)
            {
                films.Add(item);
            }
            films.Reverse();
            UpdateListBox(AllLimits(films));
        }
        private void Genre_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Genre_comboBox.SelectedIndex == 0)
            {
                Genre_listBox.Items.Clear();
                UpdateListBox(AllLimits(filmList));
                return;
            }
            Genre_listBox.Items.Add(Genre_comboBox.SelectedItem);
            UpdateListBox(AllLimits(filmList));
        }
        private void Actor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Actor_comboBox.SelectedIndex == 0)
            {
                Actor_listBox.Items.Clear();
                UpdateListBox(AllLimits(filmList));
                return;
            }
            Actor_listBox.Items.Add(Actor_comboBox.SelectedItem);
            UpdateListBox(AllLimits(filmList));
        }
        private void Country_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Producer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }
        private void Rating1_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Rating2_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Year1_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Year2_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }
        private void Budget1_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Budget2_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Box1_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private void Box2_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(AllLimits(filmList));
        }

        private List<Film> AllLimits(List<Film> filmList)
        {
            List<Genre> genres = new List<Genre>();
            foreach (Genre g in Genre_listBox.Items)
                genres.Add(g);
            List<MovieEmployee> actors = new List<MovieEmployee>();
            foreach (MovieEmployee w in Actor_listBox.Items)
                actors.Add(w);
            List<DemoCountry> demo = new List<DemoCountry>();
            foreach (DemoCountry d in DemoCountries_listBox.Items)
                demo.Add(d);
            List<Film> list = null;
            list = filmList.Where(f => genres.All(gl => f.Genres.Any(g => g.Name == gl.Name))).ToList();
            if (genres.Count == 0)
                list = filmList;
            List<Film> list1 = null;
            list1 = list.Where(f => actors.All(a => f.Actors.Any(ac => ac.FirstName == a.FirstName && ac.LastName == a.LastName))).ToList();
            if (actors.Count == 0)
                list1 = list;
            List<Film> list2 = null;
            list2 = list1.Where(f => f.CountryProduce == Country_comboBox.SelectedItem).ToList();
            if (Country_comboBox.SelectedIndex == 0)
                list2 = list1;
            List<Film> list3 = null;
            list3 = list2.Where(f => f.FilmProduser == Producer_comboBox.SelectedItem).ToList();
            if (Producer_comboBox.SelectedIndex == 0)
                list3 = list2;
            List<Film> list4 = null;
            list4 = list3.Where(f => (Decimal)f.Rating >= Rating1_numericUpDown.Value && (Decimal)f.Rating <= Rating2_numericUpDown.Value).ToList();
            List<Film> list5 = null;
            list5 = list4.Where(f => f.Year.Year >= Year1_numericUpDown.Value && f.Year.Year <= Year2_numericUpDown.Value).ToList();
            List<Film> list6 = null;
            list6 = list5.Where(f => f.Budget >= Budget1_numericUpDown.Value && f.Budget <= Budget2_numericUpDown.Value).ToList();
            List<Film> list7 = null;
            list7 = list6.Where(f => f.BoxOffice >= Box1_numericUpDown.Value && f.BoxOffice <= Box2_numericUpDown.Value).ToList();
            List<Film> list8 = null;
            list8 = list7.Where(f => demo.All(d => f.CountriesDemonstration.Any(c => c.Name == d.Name) == true)).ToList();
            if (demo.Count == 0)
                list8 = list7;
            return list8;
        }

        private void DeleteFilm_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Фильм \"{((Film)Films_listBox.SelectedItem).Name}\" успешно удалён");
            filmList.Remove((Film)Films_listBox.SelectedItem);
            Films_listBox.Items.Remove((Film)Films_listBox.SelectedItem);
        }

        private void Films_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
