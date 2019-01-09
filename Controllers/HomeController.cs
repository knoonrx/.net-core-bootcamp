﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            var newUpMyModel = new Book
            {
                Title = "Brandão é o cara",
                Author = "Rodrigo Brandão",                
            };
            return View(newUpMyModel);
        }
    }
}