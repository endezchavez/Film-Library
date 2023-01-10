using FilmLibrary;
using FilmLibrary.DataAccess;
using FilmLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibraryUI
{
    public partial class AddFilmForm : Form
    {
        public event EventHandler FilmAdded;

        protected virtual void OnFilmAdded(EventArgs e)
        {
            EventHandler eh = FilmAdded;
            if(eh != null)
            {
                eh(this, e);
            }
        }

        public AddFilmForm()
        {
            InitializeComponent();
        }

        private void AddFilmButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                FilmModel model = new FilmModel(
                    FilmTitleValue.Text, 
                    FilmDescriptionValue.Text, 
                    FilmReleaseDateMonthCalander.SelectionStart, 
                    FilmRatingValue.Text);

                GlobalConfig.Connection.CreateFilm(model);

                FilmTitleValue.Text = ""; ;
                FilmDescriptionValue.Text = "";
                FilmReleaseDateMonthCalander.SelectionStart = DateTime.Now;
                FilmRatingValue.Text = "0";

                OnFilmAdded(null);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if(FilmTitleValue.Text == "" || FilmDescriptionValue.Text == "")
            {
                output = false;
            }

            DateTime dt = FilmReleaseDateMonthCalander.SelectionStart;

            if(dt > DateTime.Today)
            {
                output = false;
            }

            decimal rating = 0;
            bool ratingValid = decimal.TryParse(FilmRatingValue.Text, out rating);

            if (!ratingValid)
            {
                output = false;
            }

            if(rating < 0 || rating > 10)
            {
                output = false;
            }

            return output;
        }
    }
}
