﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context { get; set; }

        public MoviesController()
        {
            this._context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            this._context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = this._context.Movies.Include( m => m.Genre ).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = this._context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movies == null)
            {
                return HttpNotFound();
            }

            return View(movies);
        }

    }
}