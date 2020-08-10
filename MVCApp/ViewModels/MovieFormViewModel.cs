using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Test2.Models;

namespace Test2.ViewModels
{
    public class MovieFormViewModel
    {

        public int? Id { get; set; }

        [Display(Name = "Genre id   ")]
        public byte? GenreId { get; set; }


        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in stock")]
        public int? NumberInStock { get; set; }



        [Display(Name = "Release date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }



        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit movie" : "New movie";
            }
        }


        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;   

        }

    }
}