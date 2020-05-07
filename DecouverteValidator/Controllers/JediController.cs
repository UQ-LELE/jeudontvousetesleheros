using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecouverteValidator.Models;
using Microsoft.AspNetCore.Mvc;

namespace DecouverteValidator.Controllers
{
    public class JediController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Jedi jedi)
        {
            if (ModelState.IsValid)
            {
                //Je pourrai allez enregistrer en bdd
            }

            return this.View(jedi);
        }
    }
}