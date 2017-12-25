using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebController.Entities;

namespace WebController.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ArtistContext _context;

        public ReviewsController(ArtistContext context)
        {
            _context = context;
        }

        // GET: Reviews
        public ActionResult Index([Bind(Prefix = "id")]int ArtistId)
        {

            var model = _context.Artists.Include(r => r.Reviews).SingleOrDefault(d => d.Id == ArtistId);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        public IActionResult Create(int ArtistId)
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Review view)
        {
            if (ModelState.IsValid)
            {
                _context.Review.Add(view);
                _context.SaveChanges();
                return RedirectToAction("Index", new { id = view.ArtistId });
            }
            return View(view);
        }


      


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }






        [HttpGet]
        public IActionResult Edit(int ArtId)
        {

            var q = _context.Review.Find(ArtId);
               
            return View(q);
        }


        [HttpPost]
        public IActionResult Edit(Review review)
        {
            if (ModelState.IsValid)
            {
                // context.Reviews.Add(review);
                _context.Entry(review).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index", new { id = review.ArtistId });
            }

            return View(review);

        }

       
    }
}
