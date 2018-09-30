using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Transportation.Application.Interfaces;
using Transportation.Application.ViewModels;
using Transportation.UI.Mvc.Models;

namespace Transportation.UI.Mvc.Controllers
{
    public class FerroviasController : Controller
    {
        private readonly IFerroviaAppService _ferroviaAppService;

        public FerroviasController(IFerroviaAppService ferroviaAppService)
        {
            _ferroviaAppService = ferroviaAppService;
        }

        // GET: Ferrovias
        public ActionResult Index()
        {
            return View(_ferroviaAppService.ObterTodos());
        }

        // GET: Ferrovias/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ferrovia = _ferroviaAppService.ObterPorId(id.Value);

            if (ferrovia == null)
            {
                return HttpNotFound();
            }
            return View(ferrovia);
        }

        // GET: Ferrovias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ferrovias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FerroviaViewModel ferroviaViewModel)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    _ferroviaAppService.Adicionar(ferroviaViewModel);
                    return RedirectToAction("Index");
                }

                return View(ferroviaViewModel);
            }

            return View(ferroviaViewModel);
        }

        // GET: Ferrovias/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ferrovia = _ferroviaAppService.ObterPorId(id.Value);
            if (ferrovia == null)
            {
                return HttpNotFound();
            }
            return View(ferrovia);
        }

        // POST: Ferrovias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FerroviaViewModel ferroviaViewModel)
        {
            if (ModelState.IsValid)
            {
                _ferroviaAppService.Atualizar(ferroviaViewModel);
                return RedirectToAction("Index");
            }
            return View(ferroviaViewModel);
        }

        // GET: Ferrovias/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ferrovia = _ferroviaAppService.ObterPorId(id.Value);
            if (ferrovia == null)
            {
                return HttpNotFound();
            }
            return View(ferrovia);
        }

        // POST: Ferrovias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _ferroviaAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _ferroviaAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
