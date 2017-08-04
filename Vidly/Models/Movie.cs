﻿
namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string DateAdded { get; set; }
        public int NumberInStocks { get; set; }
    }
}
