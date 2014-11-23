using System;

namespace ProjectAslym.Entities.Series
{
    public class Episode
    {
        public int TvDbId { get; set; }

        public int Season { get; set; }

        public int EpisodeNumber { get; set; }

        public string Title { get; set; }

        public string Overview { get; set; }

        public DateTime FirstAired { get; set; }

        public Rating Rating { get; set; }

    }
}