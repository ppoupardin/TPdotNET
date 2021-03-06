﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
    }
    public class MovieList
    {
        public List<MovieDTO> MoviesList { get; set; }
    }
}
