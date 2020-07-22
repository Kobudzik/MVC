using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Movie
    {
        public byte Id { get; set; }
        public byte GenreId { get; set; }
        public Genre Genre { get; set; }
        public string Name { get; set; } 
        public int NumberInStock { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
