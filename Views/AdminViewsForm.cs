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
    public partial class AdminViewsForm : Form
    {
        AddMovieForm addMovieForm;
        AddMovieEmployeeForm addMovieEmployeeForm;

       RequestForm requestForm;

        public AdminViewsForm()
        {
            InitializeComponent();
        }

        private void AddFilmworker_button_Click(object sender, EventArgs e)
        {
            addMovieEmployeeForm = new AddMovieEmployeeForm();
            addMovieEmployeeForm.ShowDialog();
        }

        private void Addfilm_button_Click(object sender, EventArgs e)
        {
            addMovieForm = new AddMovieForm();
            addMovieForm.ShowDialog();
        }

    

        private void QueryForm_button_Click_1(object sender, EventArgs e)
        {
            requestForm = new RequestForm();
            requestForm.ShowDialog();
        }
    }
}
