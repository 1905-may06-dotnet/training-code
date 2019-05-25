using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RestaurantReviews.WebApp.Models;
using Lib = RestaurantReviews.Library;

namespace RestaurantReviews.WebApp.Controllers
{
    public class ReviewController : Controller
    {
        public Lib.IRestaurantRepository Repo { get; }

        public ReviewController(Lib.IRestaurantRepository repo)
        {
            Repo = repo;
        }

        // GET: Review/Details/5
        public ActionResult Details(int id)
        {
            Lib.Review libReview = Repo.GetReviewById(id);
            var restaurantId = Repo.RestaurantIdFromReviewId(id);
            var webRest = new Review
            {
                Id = libReview.Id,
                ReviewerName = libReview.ReviewerName,
                Score = libReview.Score,
                Text = libReview.Text,
                RestaurantId = restaurantId
            };
            return View(webRest);
        }

        // GET: Review/Create?restaurantId=5
        public ActionResult Create([FromQuery]int restaurantId)
        {
            var review = new Review
            {
                RestaurantId = restaurantId
            };
            return View(review);
        }

        // POST: Review/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ReviewerName,Score,Text,RestaurantId")]Review review)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(review);
                }

                Lib.Restaurant libRestaurant = Repo.GetRestaurantById(review.RestaurantId);
                var libReview = new Lib.Review
                {
                    ReviewerName = review.ReviewerName,
                    Score = review.Score,
                    Text = review.Text
                };
                Repo.AddReview(libReview, libRestaurant);
                Repo.Save();

                return RedirectToAction(nameof(RestaurantController.Details),
                    "Restaurant", new { id = review.RestaurantId });
            }
            catch
            {
                return View(review);
            }
        }

        // GET: Review/Delete/5
        public ActionResult Delete(int id)
        {
            Lib.Review libReview = Repo.GetReviewById(id);
            var restaurantId = Repo.RestaurantIdFromReviewId(id);
            var webRest = new Review
            {
                Id = libReview.Id,
                ReviewerName = libReview.ReviewerName,
                Score = libReview.Score,
                Text = libReview.Text,
                RestaurantId = restaurantId
            };
            return View(webRest);
        }

        // POST: Review/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, [BindNever]IFormCollection collection)
        {
            try
            {
                var restaurantId = Repo.RestaurantIdFromReviewId(id);
                Repo.DeleteReview(id);
                Repo.Save();

                return RedirectToAction(nameof(RestaurantController.Details),
                    "Restaurant", new { id = restaurantId });
            }
            catch
            {
                return View();
            }
        }
    }
}