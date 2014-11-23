using System;
using System.Collections.Generic;
using ProjectAslym.Entities.Enums;

namespace ProjectAslym.Entities.Series
{
    public class Series
    {
        public int TvDbId { get; set; }

        public int ImdbId { get; set; }

        public int TvRageId { get; set; }


        public string Title { get; set; }

        public string Overview { get; set; }

        public int Year { get; set; }

        public Rating Rating { get; set; }

        public IList<string> Genres { get; set; }

        public IList<Actor> Actors { get; set; } 

        public SeriesStatus SeriesStatus { get; set; }


        public DateTime FirstAired { get; set; }

        public AirDay AirDay { get; set; }

        public string AirTime { get; set; }

        public string Network { get; set; }

        public string Cerification { get; set; }

        public string RootFolderPath { get; set; }
        public DateTime Added { get; set; }

        public IList<Season> Seasons { get; set; } 
    }
}