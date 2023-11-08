﻿using System.ComponentModel.DataAnnotations;

namespace eMovieTicketSite.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        public string? ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        public string? FullName { get; set; }
        [Display(Name = "Biography")]
        public string? Bio { get; set; }
        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
