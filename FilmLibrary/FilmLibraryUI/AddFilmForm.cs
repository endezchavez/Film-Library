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

        /// <summary>
        /// An event that is triggered when a new film is added
        /// </summary>
        /// <param name="e">Any arguments required for the event</param>
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

        /// <summary>
        /// Adds a new film to the selected connection (Text file or Database) and triggers an event for changes in the main form
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Any arguments required for the event</param>
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
        /// <summary>
        /// Validates the user's input and displays error label's if input is invalid and displays error label's if input is invalid
        /// </summary>
        /// <returns>Whether or not the input from the user is valid</returns>
        private bool ValidateForm()
        {
            bool output = true;

            if(FilmTitleValue.Text == "")
            {
                output = false;

                FilmTitleErrorLabel.Text = "Film title must contain at least 1 character";
            }
            else
            {
                FilmTitleErrorLabel.Text = "";
            }

            if (FilmDescriptionValue.Text == "")
            {
                output = false;

                FilmDescriptionErrorLabel.Text = "Film description must contain at least 1 character";
            }
            else
            {
                FilmDescriptionErrorLabel.Text = "";
            }

            DateTime dt = FilmReleaseDateMonthCalander.SelectionStart;

            if(dt > DateTime.Today)
            {
                output = false;

                FilmReleaseDateErrorLabel.Text = "Film release date must be earlier than today";
            }
            else
            {
                FilmReleaseDateErrorLabel.Text = "";
            }

            decimal rating = 0;
            bool ratingValid = decimal.TryParse(FilmRatingValue.Text, out rating);

            if (!ratingValid)
            {
                output = false;

                FilmRatingErrorLabel.Text = "Film rating must be a number e.g(7.8)";
            }

            if (rating < 0 || rating > 10)
            {
                output = false;

                FilmRatingErrorLabel.Text = "Film rating must be between 0 and 10";
            }

            if(ratingValid && (rating >= 0 && rating <= 10))
            {
                FilmRatingErrorLabel.Text = "";
            }

            return output;
        }

    }
}
