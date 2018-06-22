﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using VidBox.Models;
using VidBox.ViewModels;

namespace VidBox.Controllers
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
        // GET: Customers
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }
        // GET: Customers/Details/{id}
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }
        // GET : Customers/New
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieViewModel
            {
                Movie = new Movie(),
                Genres = genres
            };
            return View(viewModel);
        }
        // GET : Customers/Edit/{id}
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };
                return View("New", viewModel);
            }
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };
                return View("Edit", viewModel);
            }
            var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

            movieInDb.Name = movie.Name;
            movieInDb.GenreId = movie.GenreId;
            movieInDb.ReleaseDate = movie.ReleaseDate;
            movieInDb.DateAdded = movie.DateAdded;
            movieInDb.NumberInStock = movie.NumberInStock;

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}