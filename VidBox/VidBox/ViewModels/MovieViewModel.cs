using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidBox.Models;

namespace VidBox.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}