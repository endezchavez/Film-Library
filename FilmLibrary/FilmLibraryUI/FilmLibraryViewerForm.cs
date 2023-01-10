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

        private void FilmAdded(object sender, EventArgs e)
        {
            filmList = GlobalConfig.Connection.GetFilm_All();
            WireUpFilmList();
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
            if (!Application.OpenForms.OfType<EditFilmForm>().Any())
            {
                AddFilmForm addFilmForm = new AddFilmForm();
                addFilmForm.FilmAdded += new EventHandler(FilmAdded);
                addFilmForm.Show();
            }
        }
    }
}