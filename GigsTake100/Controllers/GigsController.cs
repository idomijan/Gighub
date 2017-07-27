using GigsTake100.Models;
using GigsTake100.Viewmodels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigsTake100.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Gigs
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            var  artistId = User.Identity.GetUserId(); // 
                                                       //var artist = _context.Users.Single(u => u.Id == ArtistId);
                                                       //var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);

            if (!ModelState.IsValid)

                viewModel.Genres = _context.Genres.ToList();
                return View("Create", viewModel);

            var gig = new Gig {
                ArtistId = artistId,
                DateTime = viewModel.GetDateTime(),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

            _context.Gigs.Add(gig);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}