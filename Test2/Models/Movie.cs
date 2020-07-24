using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Movie
    {
        public byte Id { get; set; }

        [Display(Name = "Genre id   ")]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }
        public string Name { get; set; }

        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }

        [Display(Name = "Date added")]
        public DateTime DateAdded { get; set; }

        [Display (Name="Release date")]
        public DateTime ReleaseDate { get; set; }
    }
}
