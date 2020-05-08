using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontvousetesleheros.Core.Data;
using jeudontvousetesleheros.Core.Data.DataLayer;
using jeudontvousetesleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontvousetesleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        private readonly DefaultContext _context = null;

        private ParagrapheDataLayer _paragrapheDataLayer = null;
        public AventureController(DefaultContext context, ParagrapheDataLayer paragrapheDataLayer)
        {
            this._context = context;
            this._paragrapheDataLayer = paragrapheDataLayer;
        }

        public ActionResult Index()
        {
            this.ViewBag.MonTitre = "Aventures";

            var query = from item in this._context.Aventures
                        select item;

            return View(query.ToList());
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Aventure aventure)
        {
            ActionResult result = this.View(aventure);

            if (ModelState.IsValid)
            {
                this._context.Aventures.Add(aventure);
                this._context.SaveChanges();

                result = this.RedirectToAction("BeginNewOne");
            }

            return result;
        }

        public ActionResult BeginNewOne(int id)
        {
            Paragraphe item = null;

            if(id == 0)
            {
                item = this._paragrapheDataLayer.GetFirst();

            }
            else
            {
                item = this._paragrapheDataLayer.GetOne(id);
            }

            return this.View(item);
        }

        public ActionResult Edit(int id)
        {
            return this.View();
        }
    }
}