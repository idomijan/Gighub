using System;
using System.ComponentModel.DataAnnotations;

namespace GigsTake100.Models
{
    public class Gig
    {
        public int Id { get; set; }
        public ApplicationUser Artist { get; set; }
        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue  { get; set; }

        
        public Genre Genre { get; set; }
        [Required] //foreign key property, optimization
        public byte GenreId { get; set; }
    }

    
}