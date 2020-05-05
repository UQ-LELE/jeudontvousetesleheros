using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontvousetesleheros.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontvousetesleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MonTitre = "Aventures";

            List<Aventure> maList = new List<Aventure>();

            maList.Add(new Aventure()
            {
                Id = 1,
                Titre = "ma premiere aventure"
            }); 
            
            maList.Add(new Aventure()
            {
                Id = 2,
                Titre = "ma seconde aventure"
            });

            return View(maList);
        }
    }
}