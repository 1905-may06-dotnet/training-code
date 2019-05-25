using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReviews.WebApp.Models
{
    public class Restaurant
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<Review> Reviews { get; set; }

        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public double? Score { get; set; }
    }
}
