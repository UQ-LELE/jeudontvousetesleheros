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
        #region à supprimer après Entities
        private List<Paragraphe> _maList = new List<Paragraphe>()
        {
            new Paragraphe(){Id=1, Numero=1, Titre="Titre 1"},
            new Paragraphe(){Id=2, Numero=10, Titre="Titre 2"},
            new Paragraphe(){Id=5, Numero=14, Titre="Titre 2"}
        };
        #endregion

        #region Méthodes publiques

        public ActionResult Index()
        {

            return this.View();
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return this.View();
        }

        public ActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;

            paragraphe = _maList.First(item => item.Id == id);

            return this.View(paragraphe);
        }

        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            return this.View();
        }


        #endregion
    }
}