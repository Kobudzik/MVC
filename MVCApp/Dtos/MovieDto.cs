using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Test2.Models;

namespace Test2.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public byte GenreId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        public GenreDto Genre { get; set; }

    }
}