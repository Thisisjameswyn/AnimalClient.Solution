using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnimalClient.Models;

namespace AnimalClient.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly ILogger<AnimalsController> _logger;

        public AnimalsController(ILogger<AnimalsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          var allAnimals = Animal.GetAnimals();
          return View(allAnimals);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
