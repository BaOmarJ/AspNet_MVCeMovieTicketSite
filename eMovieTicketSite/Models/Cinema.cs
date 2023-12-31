﻿using System.ComponentModel.DataAnnotations;

namespace eMovieTicketSite.Models
{
    public class Cinema
    {
        [Key] 
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string? Logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = null;
        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
