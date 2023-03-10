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
    public partial class MovieEmployeeInfoForm : Form
    {
        Actor actor;
        Produser produser;
        MovieEmployee employee;

        public MovieEmployeeInfoForm(MovieEmployee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.Load += MovieEmployeeInfoForm_Load;
        }

        private async void MovieEmployeeInfoForm_Load(object sender, EventArgs e)
        {
            actor = (await DbNewService.Instance.GetActorsAsync()).FirstOrDefault(a => a.FirstName == employee.FirstName &&
            a.LastName == employee.LastName && a.Birthday == employee.Birthday);
            produser = (await DbNewService.Instance.GetProdusersAsync()).FirstOrDefault(a => a.FirstName == employee.FirstName &&
            a.LastName == employee.LastName && a.Birthday == employee.Birthday);
            MovieEmployeeInfoVisual();
        }

        private void MovieEmployeeInfoVisual()
        {
            Name_label.Text = employee.ToString();
            Info_label.Text = $"Пол: {employee.Sex}\nДата рождения: {employee.Birthday}\n";
            Info_label.Text += $"Место рождения: {employee.Nation.ToString()}, {employee.City}\n";
            Info_label.Text += $"Финансовое состояние: {employee.FinState}$";
            if (produser != null)
                (produser).MovieProduce.ToList().ForEach(f => ProducedFilms_listBox.Items.Add(f));
            else
            {
                ProducedFilms_listBox.Visible = false;
                ProducedFilm_label.Visible = false;
                Filmography_listBox.Location = new Point(294, Filmography_listBox.Location.Y);
                Filmography_label.Location = new Point(294, Filmography_label.Location.Y);
                this.Size = new Size(500, this.Size.Height);
            }
            if (actor != null)
                (actor).MovieLibrary.ToList().ForEach(f => Filmography_listBox.Items.Add(f));
            else
            {
                Filmography_label.Visible = false;
                Filmography_listBox.Visible = false;
                this.Size = new Size(500, this.Size.Height);
            }
        }

    }
}
