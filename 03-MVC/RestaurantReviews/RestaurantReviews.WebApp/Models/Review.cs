﻿using System.ComponentModel.DataAnnotations;

namespace RestaurantReviews.WebApp.Models
{
    public class Review
    {
        // the HTML/tag helpers like "DisplayNameFor"
        // will use this instead of the property's name
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Reviewer Name")]
        public string ReviewerName { get; set; }

        [Required]
        [Range(0, 10)]
        public int? Score { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(2048)]
        public string Text { get; set; }

        [Display(Name = "Restaurant ID")]
        public int RestaurantId { get; set; }
    }
}