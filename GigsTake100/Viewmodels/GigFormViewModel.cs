using GigsTake100.Models;

using System.Collections.Generic;
using System;

namespace GigsTake100.Viewmodels
{
    public class GigFormViewModel
    {
        public DateTime DateTime {
        get { return DateTime.Parse(string.Format("{0} {1}", Date, Time));           }
        }

        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

    }
}