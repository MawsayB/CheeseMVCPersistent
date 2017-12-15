using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Data;

namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var allCategories = context.Categories.ToList();
            return View(allCategories);
        }

        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)

        {
            context = dbContext;
        }
    }
}