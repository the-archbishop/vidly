﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies/
        [Route("movies/")]
        public ActionResult Movies()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        // GET: customers/details/id
        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {

            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);


            if (movie == null)
                return HttpNotFound();


            return View(movie);
        }

        // GET: movies/released/year
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}