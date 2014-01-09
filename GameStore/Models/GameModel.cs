using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }

        public GameModel(int id, string name, DateTime releaseDate, string genre, string coverImage, string description, string publisher)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            Genre = genre;
            CoverImage = coverImage;
            Description = description;
            Publisher = publisher;
        }
    }
}