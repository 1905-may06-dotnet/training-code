using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantReviews.Context
{
    public static class Mapper
    {
        public static Library.Restaurant Map(Restaurant restaurant) => new Library.Restaurant
        {
            Id = restaurant.Id,
            Name = restaurant.Name,
            Reviews = Map(restaurant.Review).ToList()
        };

        public static Restaurant Map(Library.Restaurant restaurant) => new Restaurant
        {
            Id = restaurant.Id,
            Name = restaurant.Name,
            Review = Map(restaurant.Reviews).ToList()
        };
        
        public static Library.Review Map(Review review) => new Library.Review
        {
            Id = review.Id,
            ReviewerName = review.ReviewerName,
            Score = review.Score,
            Text = review.Text
        };

        public static Review Map(Library.Review review) => new Review
        {
            Id = review.Id,
            ReviewerName = review.ReviewerName,
            Score = review.Score ?? throw new ArgumentException("review score cannot be null.", nameof(review)),
            Text = review.Text
        };

        public static IEnumerable<Library.Restaurant> Map(IEnumerable<Restaurant> restaurants) => restaurants.Select(Map);

        public static IEnumerable<Restaurant> Map(IEnumerable<Library.Restaurant> restaurants) => restaurants.Select(Map);

        public static IEnumerable<Library.Review> Map(IEnumerable<Review> reviews) => reviews.Select(Map);

        public static IEnumerable<Review> Map(IEnumerable<Library.Review> reviews) => reviews.Select(Map);
    }
}
