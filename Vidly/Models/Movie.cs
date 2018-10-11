﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Released Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }
    }
}