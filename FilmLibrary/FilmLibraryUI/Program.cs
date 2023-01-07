namespace FilmLibraryUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Initialize database connections
            FilmLibrary.GlobalConfig.InitializeConnections(true, true);
            //Application.Run(new FilmLibraryViewerForm());
            Application.Run(new AddFilmForm());
        }
    }
}