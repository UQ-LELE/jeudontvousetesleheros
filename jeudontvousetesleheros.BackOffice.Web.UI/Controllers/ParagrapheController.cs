using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontvousetesleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontvousetesleheros.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region Méthodes publiques

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return this.View();
        }
        #endregion
    }
}