﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;

namespace CheeseMVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly CheeseDbContext context;

        public MenuController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            IList<CheeseMenu> cheeseMenu = context.CheeseMenus.ToList();
            return View(cheeseMenu);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddMenuViewModel addMenuViewModel = new AddMenuViewModel();
            return View(addMenuViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddMenuViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new category to my existing cheeses
                CheeseCategory newCheeseCategory = new CheeseCategory
                {
                    newMenu = addMenuViewModel.Name,
                };

                context.Menus.Add(newAddMenuViewModel);
                context.SaveChanges();

                return Redirect("/Menu/ViewMenu/" + newMenu.ID);
            }

            return View(addMenuViewModel);
        }

        [HttpGet]
        public IActionResult ViewMenu(int id)
        {
            ViewMenu newViewMenu menu = context.DbSet.Single(m => m.ID == addMenuViewModel.MenuID);

            {
                List<CheeseMenu> items = context
                    .CheeseMenus
                    .Include(item => item.Cheese)
                    .Where(cm => cm.MenuID == id)
                    .ToList();
            }

            return View(ViewMenuViewModel);
        }
    }
}