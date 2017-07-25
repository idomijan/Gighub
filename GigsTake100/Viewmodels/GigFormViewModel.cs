using GigsTake100.Models;

using System.Collections.Generic;

namespace GigsTake100.Viewmodels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

    }
}