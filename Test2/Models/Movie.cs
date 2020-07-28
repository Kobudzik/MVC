using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Genre id   ")]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name = "Number in stock")]
        public byte NumberInStock { get; set; }

        [Display(Name = "Date added")]
        public DateTime DateAdded { get; set; }

        [Display (Name="Release date")]
        public DateTime ReleaseDate { get; set; }
    }
}
