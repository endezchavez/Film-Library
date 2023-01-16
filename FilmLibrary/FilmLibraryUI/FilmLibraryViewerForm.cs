using FilmLibrary;
using FilmLibrary.Models;
using System.DirectoryServices.ActiveDirectory;

namespace FilmLibraryUI
{
    public partial class FilmLibraryViewerForm : Form
    {
        private List<FilmModel> filmList = GlobalConfig.Connection.GetFilm_All();

        /// <summary>
        /// Wire's up the film list box with the data from the given connection (Text file or Database)
        /// </summary>
        private void WireUpFilmList()
        {
            FilmLibraryListBox.DataSource = null;

            FilmLibraryListBox.DataSource = filmList;
            FilmLibraryListBox.DisplayMember = "Title";
        }

        /// <summary>
        /// Wire's up the sort by combo box with the data from the SortType enum
        /// </summary>
        private void WireUpSortByComboBox()
        {
            foreach (SortType sortType in Enum.GetValues(typeof(SortType)))
            {
                var item = new ComboBoxItem<SortType>();
                item.DisplayMember = SortTypeExtensions.ToString(sortType);
                item.ValueMember = sortType;
                SortByComboBox.Items.Add(item);
            }

            SortByComboBox.SelectedItem = SortByComboBox.Items[0];

        }

        /// <summary>
        /// Rewires up the list of films when a film is added or updated
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Any arguments required for the event</param>
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

        /// <summary>
        /// Creates dummy sample data for testing purposes
        /// </summary>
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

            WireUpSortByComboBox();
        }

        /// <summary>
        /// Updates the text fields whenever the selected film is changed
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Any arguments required for the event</param>
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

        /// <summary>
        /// Opens an Add Film window if one is not already open and subscribes it to the FilmAddedOrUpdated event
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Any arguments required for the event</param>
        private void AddFilmButton_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<AddFilmForm>().Any())
            {
                AddFilmForm addFilmForm = new AddFilmForm();
                addFilmForm.FilmAdded += new EventHandler(FilmAddedOrUpdated);
                addFilmForm.Show();
            }
        }

        /// <summary>
        /// Opens an Edit Film window if one is not already open and subscribes it to the FilmAddedOrUpdated event
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Any arguments required for the event</param>
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

        /// <summary>
        /// Rewires the film list when the seacrh field is changed and queries the given connection for all films that match the search
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Any arguments required for the event</param>
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            filmList = GlobalConfig.Connection.GetFilm_ByTitle(SearchBox.Text);

            WireUpFilmList();

        }

        /// <summary>
        /// Rewires the film list when the Sort By type is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch ((SortType)SortByComboBox.SelectedIndex)
            {
                case SortType.RATING_HIGH_TO_LOW:
                    filmList = filmList.OrderByDescending(x => x.Rating).ToList();
                    break;
                case SortType.RATING_LOW_TO_HIGH:
                    filmList = filmList.OrderBy(x => x.Rating).ToList();
                    break;
                case SortType.RELEASE_DATE_ASCENDING:
                    filmList = filmList.OrderBy(x => x.ReleaseDate).ToList();
                    break;
                case SortType.RELEASE_DATE_DESCENDING:
                    filmList = filmList.OrderByDescending(x => x.ReleaseDate).ToList();
                    break;
            }

            WireUpFilmList();
        }
    }
}