using System;
using System.Collections.Generic;
using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class CategoryController : Controller
	{
        private readonly AppplicationDbContext _db;

        public CategoryController(AppplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objcategory = _db.Categories.ToList();


            return View(objcategory);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Name and Dispaly Order can not be equal");
            }
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}

