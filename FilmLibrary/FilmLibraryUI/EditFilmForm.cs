using FilmLibrary;
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
    public partial class EditFilmForm : Form
    {
        public event EventHandler FilmDataChanged;

        /// <summary>
        /// An event that is triggered when a film's data is changed
        /// </summary>
        /// <param name="e">Any arguments required for the event</param>
        protected virtual void OnFilmDataChanged(EventArgs e)
        {
            EventHandler eh = FilmDataChanged;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        /// <summary>
        /// Updates film's data on the selected connection type (Text file or Database) and fires event for changes to be made in main form
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Any arguments required for the event</param>
        private void UpdateFilmButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                selectedModel.Title = FilmTitleValue.Text;
                selectedModel.Description = FilmDescriptionValue.Text;
                selectedModel.ReleaseDate = FilmReleaseDateMonthCalander.SelectionStart;
                decimal ratingValue = 0;
                decimal.TryParse(FilmRatingValue.Text, out ratingValue);
                selectedModel.Rating = ratingValue;

                GlobalConfig.Connection.UpdateFilm(selectedModel);

                OnFilmDataChanged(null);

                this.Close();
            }
        }

        /// <summary>
        /// Shows Dialog box asking if user is sure they want to delete and if so deletes film from selected connection (Text file or Database)
        /// and fires event for changes to be made in main form
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Any arguments required for the event</param>
        private void DeleteFilmButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this film?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GlobalConfig.Connection.DeleteFilm(selectedModel);

                OnFilmDataChanged(null);

                this.Close();
            }
        }

        private FilmModel selectedModel;

        public EditFilmForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor populates film data fields given a selected film
        /// </summary>
        /// <param name="selectedModel">The selected film for editing</param>
        public EditFilmForm(FilmModel selectedModel)
        {
            InitializeComponent();
            this.selectedModel = selectedModel;

            FilmTitleValue.Text = selectedModel.Title;
            FilmDescriptionValue.Text = selectedModel.Description;
            FilmReleaseDateMonthCalander.SelectionStart = selectedModel.ReleaseDate;
            FilmRatingValue.Text = selectedModel.Rating.ToString();
        }

        /// <summary>
        /// Validates the user's input and displays error label's if input is invalid
        /// </summary>
        /// <returns>Whether or not the input from the user is valid</returns>
        private bool ValidateForm()
        {
            bool output = true;

            //Check if information has changed
            if (FilmTitleValue.Text.Equals(selectedModel.Title) &&
                FilmDescriptionValue.Text.Equals(selectedModel.Description) &&
                FilmReleaseDateMonthCalander.SelectionStart == selectedModel.ReleaseDate &&
                decimal.Parse(FilmRatingValue.Text) == selectedModel.Rating)
            {
                output = false;
            }

            if (FilmTitleValue.Text == "")
            {
                output = false;

                FilmTitleErrorLabel.Text = "Film title must have at least 1 character";
            }
            else
            {
                FilmTitleErrorLabel.Text = "";
            }

            if (FilmDescriptionValue.Text == "")
            {
                output = false;

                FilmDescriptionErrorLabel.Text = "Film description must have at least 1 character";
            }
            else
            {
                FilmDescriptionErrorLabel.Text = "";
            }

            DateTime dt = FilmReleaseDateMonthCalander.SelectionStart;

            if (dt > DateTime.Today)
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
