using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public enum DatabaseType
    {
        SQL,
        TEXT_FILE,
    }

    public enum SortType
    {
        RATING_HIGH_TO_LOW,
        RATING_LOW_TO_HIGH,
        RELEASE_DATE_ASCENDING,
        RELEASE_DATE_DESCENDING,
    }

    public static class SortTypeExtensions
    {
        public static string ToString(SortType sortType)
        {
            switch (sortType)
            {
                case SortType.RATING_HIGH_TO_LOW:
                    return "Rating (High - Low)";
                case SortType.RATING_LOW_TO_HIGH:
                    return "Rating (Low - High)";
                case SortType.RELEASE_DATE_ASCENDING:
                    return "Release Date (Ascending)";
                case SortType.RELEASE_DATE_DESCENDING:
                    return "Release Date (Descending)";
                default:
                    return "Invalid SortType";
            }
        }
    }
}