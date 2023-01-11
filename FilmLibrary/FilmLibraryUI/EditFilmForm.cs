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

        protected virtual void OnFilmDataChanged(EventArgs e)
        {
            EventHandler eh = FilmDataChanged;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private FilmModel selectedModel;
        public EditFilmForm()
        {
            InitializeComponent();
        }

        public EditFilmForm(FilmModel selectedModel)
        {
            InitializeComponent();
            this.selectedModel = selectedModel;

            FilmTitleValue.Text = selectedModel.Title;
            FilmDescriptionValue.Text = selectedModel.Description;
            FilmReleaseDateMonthCalander.SelectionStart = selectedModel.ReleaseDate;
            FilmRatingValue.Text = selectedModel.Rating.ToString();
        }

        private void UpdateFilmButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //TODO: Maybe create a method in FilmModel for updating information
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

        private bool ValidateForm()
        {
            //TODO: Check if information has actually changed

            bool output = true;

            if (FilmTitleValue.Text == "" || FilmDescriptionValue.Text == "")
            {
                output = false;
            }

            DateTime dt = FilmReleaseDateMonthCalander.SelectionStart;

            if (dt > DateTime.Today)
            {
                output = false;
            }

            decimal rating = 0;
            bool ratingValid = decimal.TryParse(FilmRatingValue.Text, out rating);

            if (!ratingValid)
            {
                output = false;
            }

            if (rating < 0 || rating > 10)
            {
                output = false;
            }

            return output;
        }

        private void DeleteFilmButton_Click(object sender, EventArgs e)
        {
            //TODO: Add popup box asking if the user is sure
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this film?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GlobalConfig.Connection.DeleteFilm(selectedModel);

                OnFilmDataChanged(null);

                this.Close();
            }
            
        }
    }
}
