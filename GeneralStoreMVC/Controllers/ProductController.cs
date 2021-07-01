using GeneralStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStoreMVC.Controllers
{
    public class ProductController : Controller
    {   
        private ApplicationDbContext _db = new ApplicationDbContext();// Link to database

        // GET: Product
        public ActionResult Index()
        {
            return View(_db.Products.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

    }
}