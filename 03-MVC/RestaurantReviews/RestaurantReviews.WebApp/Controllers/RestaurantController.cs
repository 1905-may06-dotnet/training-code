using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RestaurantReviews.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Lib = RestaurantReviews.Library;

namespace RestaurantReviews.WebApp.Controllers
{
    public class RestaurantController : Controller
    {
        public Lib.IRestaurantRepository Repo { get; }

        public RestaurantController(Lib.IRestaurantRepository repo)
        {
            Repo = repo;
        }

        // GET: Restaurant
        // default value for "search" means i can use this method both for search results
        // and for "show all restaurants"
        // [FromQuery] makes it explicit that i'm looking to get this from the query string
        // e.g. Restaurant?search=Fred
        // e.g. Restaurant/?search=Fred
        // e.g. Restaurant/Index?search=Fred
        // e.g. Restaurant/Index/?search=Fred
        public ActionResult Index([FromQuery]string search = "")
        {
            IEnumerable<Lib.Restaurant> libRests = Repo.GetRestaurants(search);
            IEnumerable<Restaurant> webRests = libRests.Select(x => new Restaurant
            {
                Id = x.Id,
                Name = x.Name,
                Reviews = x.Reviews.Select(y => new Review()),
                Score = x.Score
            });
            return View(webRests);
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            Lib.Restaurant libRest = Repo.GetRestaurantById(id);
            var webRest = new Restaurant
            {
                Id = libRest.Id,
                Name = libRest.Name,
                Reviews = libRest.Reviews.Select(y => new Review
                {
                    Id = y.Id,
                    ReviewerName = y.ReviewerName,
                    Score = y.Score,
                    Text = y.Text
                }),
                Score = libRest.Score
            };
            return View(webRest);
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Name")]Restaurant restaurant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repo.AddRestaurant(new Lib.Restaurant
                    {
                        Name = restaurant.Name
                    });
                    Repo.Save();

                    return RedirectToAction(nameof(Index));
                }
                return View(restaurant);
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            // we pass the current values into the Edit view
            // so that the input fields can be pre-populated instead of blank
            // (important for good UX)
            Lib.Restaurant libRest = Repo.GetRestaurantById(id);
            var webRest = new Restaurant
            {
                Id = libRest.Id,
                Name = libRest.Name
            };
            return View(webRest);
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        // without [Bind("Name")], this would look in the request body, or query string
        // for the restaurant.Id and for restaurant.Reviews
        // this way, it will only try to bind restaurant.Name, and will leave other properties
        // at default.
        // this is really more of a security thing, because your rendered views should only
        // be sending what you expect
        public ActionResult Edit([FromRoute]int id, [Bind("Name")]Restaurant restaurant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Lib.Restaurant libRest = Repo.GetRestaurantById(id);
                    libRest.Name = restaurant.Name;
                    Repo.UpdateRestaurant(libRest);
                    Repo.Save();

                    return RedirectToAction(nameof(Index));
                }
                return View(restaurant);
            }
            catch (Exception)
            {
                return View(restaurant);
            }
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            Lib.Restaurant libRest = Repo.GetRestaurantById(id);
            var webRest = new Restaurant
            {
                Id = libRest.Id,
                Name = libRest.Name
            };
            return View(webRest);
        }

        // POST: Restaurant/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, [BindNever]IFormCollection collection)
        {
            try
            {
                Repo.DeleteRestaurant(id);
                Repo.Save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}