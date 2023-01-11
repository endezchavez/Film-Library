using FilmLibrary;
using FilmLibrary.Models;
using System.DirectoryServices.ActiveDirectory;

namespace FilmLibraryUI
{
    public partial class FilmLibraryViewerForm : Form
    {
        private List<FilmModel> filmList = GlobalConfig.Connection.GetFilm_All();
        private FilmModel selectedFilm;


        private void WireUpFilmList()
        {
            FilmLibraryListBox.DataSource = null;

            FilmLibraryListBox.DataSource = filmList;
            FilmLibraryListBox.DisplayMember = "Title";
        }

        private void FilmAddedOrUpdated(object sender, EventArgs e)
        {
            filmList = GlobalConfig.Connection.GetFilm_All();
            WireUpFilmList();

            if(filmList.Count == 0)
            {
                FilmTitleValue.Text = "<None>";
                FilmDescriptionValue.Text = "<None>";
                FilmReleaseDateValue.Text = "<None>";
                FilmRatingValue.Text = "0";
            }
        }

        private void CreateSampleData()
        {
            filmList.Add(new FilmModel { Title = "Harry Potter" });
            filmList.Add(new FilmModel { Title = "James Bond" });
            filmList.Add(new FilmModel { Title = "Shaw Shank" });
        }
             
        public FilmLibraryViewerForm()
        {
            InitializeComponent();


            //CreateSampleData();

            WireUpFilmList();
        }

        private void FilmLibraryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmModel film = (FilmModel)FilmLibraryListBox.SelectedItem;

            if(film != null)
            {
                FilmTitleValue.Text = film.Title;
                FilmDescriptionValue.Text = film.Description;
                FilmReleaseDateValue.Text = film.ReleaseDate.ToString("dd/MM/yyyy");
                FilmRatingValue.Text = film.Rating.ToString();
            }
            
        }

        private void AddFilmButton_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<AddFilmForm>().Any())
            {
                AddFilmForm addFilmForm = new AddFilmForm();
                addFilmForm.FilmAdded += new EventHandler(FilmAddedOrUpdated);
                addFilmForm.Show();
            }
        }

        private void EditFilmButton_Click(object sender, EventArgs e)
        {
            FilmModel film = (FilmModel)FilmLibraryListBox.SelectedItem;

            if (!Application.OpenForms.OfType<EditFilmForm>().Any())
            {
                EditFilmForm editFilmForm = new EditFilmForm(film);
                editFilmForm.FilmDataChanged += new EventHandler(FilmAddedOrUpdated);
                editFilmForm.Show();
            }
        }
    }
}