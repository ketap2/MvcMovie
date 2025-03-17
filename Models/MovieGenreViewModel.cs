using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; } = new();
        public SelectList Genres { get; set; } = new(Array.Empty<string>());
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
} 