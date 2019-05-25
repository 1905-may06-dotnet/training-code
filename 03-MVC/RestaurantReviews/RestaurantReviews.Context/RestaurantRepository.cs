using Microsoft.EntityFrameworkCore;
using RestaurantReviews.Library;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantReviews.Context
{
    /// <summary>
    /// A repository managing data access for restaurant objects and their review members.
    /// </summary>
    /// <remarks>
    /// This class ought to have better exception handling and logging.
    /// </remarks>
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RestaurantReviewsDBContext _db;

        /// <summary>
        /// Initializes a new restaurant repository given a suitable Entity Framework DbContext.
        /// </summary>
        /// <param name="db">The DbContext</param>
        public RestaurantRepository(RestaurantReviewsDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        /// <summary>
        /// Get all restaurants with deferred execution.
        /// </summary>
        /// <returns>The collection of restaurants</returns>
        public IEnumerable<Library.Restaurant> GetRestaurants(string search = null)
        {
            if (search == null)
            {
                // disable pointless tracking for performance
                return Mapper.Map(_db.Restaurant.Include(r => r.Review).AsNoTracking());
            }
            else
            {
                return Mapper.Map(_db.Restaurant.Include(r => r.Review)
                    .AsNoTracking().Where(r => r.Name.Contains(search)));
            }
        }

        /// <summary>
        /// Get a restaurant by ID.
        /// </summary>
        /// <returns>The restaurant</returns>
        public Library.Restaurant GetRestaurantById(int id)
        {
            // disable pointless tracking for performance
            return Mapper.Map(_db.Restaurant.Include(r => r.Review)
                .AsNoTracking().First(r => r.Id == id));
        }

        /// <summary>
        /// Add a restaurant, including any associated reviews.
        /// </summary>
        /// <param name="restaurant">The restaurant</param>
        public void AddRestaurant(Library.Restaurant restaurant)
        {
            _db.Add(Mapper.Map(restaurant));
        }

        /// <summary>
        /// Delete a restaurant by ID, including any reviews associated to it.
        /// </summary>
        /// <param name="restaurantId">The ID of the restaurant</param>
        public void DeleteRestaurant(int restaurantId)
        {
            _db.Remove(_db.Restaurant.Find(restaurantId));
        }

        /// <summary>
        /// Update a restaurant. Will not process any changes to its reviews.
        /// </summary>
        /// <param name="restaurant">The restaurant with changed values</param>
        public void UpdateRestaurant(Library.Restaurant restaurant)
        {
            // calling Update would mark every property as Modified.
            // this way will only mark the changed properties as Modified.
            _db.Entry(_db.Restaurant.Find(restaurant.Id)).CurrentValues.SetValues(Mapper.Map(restaurant));
        }

        /// <summary>
        /// Get a review.
        /// </summary>
        /// <param name="reviewId">The ID of the review</param>
        public Library.Review GetReviewById(int reviewId)
        {
            return Mapper.Map(_db.Review.AsNoTracking().First(r => r.Id == reviewId));
        }

        /// <summary>
        /// Add a review, and optionally associate it with a restaurant.
        /// </summary>
        /// <param name="review">The review</param>
        /// <param name="restaurant">The restaurant (or null if none)</param>
        public void AddReview(Library.Review review, Library.Restaurant restaurant)
        {
            if (restaurant != null)
            {
                // get the db's version of that restaurant
                // (can't use Find with Include)
                Restaurant contextRestaurant = _db.Restaurant.Include(r => r.Review)
                    .First(r => r.Id == restaurant.Id);
                restaurant.Reviews.Add(review);
                contextRestaurant.Review.Add(Mapper.Map(review));
            }
            else
            {
                _db.Add(Mapper.Map(review));
            }
        }

        /// <summary>
        /// Delete a review by ID.
        /// </summary>
        /// <param name="reviewId">The ID of the review</param>
        public void DeleteReview(int reviewId)
        {
            _db.Remove(_db.Review.Find(reviewId));
        }

        /// <summary>
        /// Update a review.
        /// </summary>
        /// <param name="review">The review with changed values</param>
        public void UpdateReview(Library.Review review)
        {
            _db.Entry(_db.Review.Find(review.Id)).CurrentValues.SetValues(Mapper.Map(review));
        }

        /// <summary>
        /// Get the ID of the restaurant associated to the review with the given ID.
        /// </summary>
        /// <param name="reviewId">The ID of the review</param>
        /// <returns></returns>
        public int RestaurantIdFromReviewId(int reviewId)
        {
            return _db.Review.AsNoTracking().First(r => r.Id == reviewId).RestaurantId;
        }

        /// <summary>
        /// Persist changes to the data source.
        /// </summary>
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
