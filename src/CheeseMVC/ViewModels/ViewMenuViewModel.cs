﻿using CheeseMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {

        [Required]
        [Display(Name = "Menu")]
        public string Menu { get; set; }

        public IList<CheeseMenu> Items { get; set; }


    }
}
