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
    public class SeriesVagoesController : Controller
    {


        private readonly ISerieVagaoAppService _serieVagaoAppService;

        public SeriesVagoesController(ISerieVagaoAppService serieVagaoAppService)
        {
            _serieVagaoAppService = serieVagaoAppService;
        }
        // GET: SeriesVagoes
        public ActionResult Index()
        {
            return View(_serieVagaoAppService.ObterTodos());
        }

        // GET: SeriesVagoes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ferrovia = _serieVagaoAppService.ObterPorId(id.Value);

            if (ferrovia == null)
            {
                return HttpNotFound();
            }
            return View(ferrovia);
        }

        // GET: SeriesVagoes/Create
        public ActionResult Create()
        {
            
            ViewBag.ClasseVagaoId = new SelectList
                (
                    _serieVagaoAppService.ListaClassesVagoes(),
                    "ClasseVagaoId",
                    "Codigo"
                );
            
            return View();
        }

        // POST: SeriesVagoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SerieVagaoId,Codigo,Descricao,ClasseVagaoId")] SerieVagaoViewModel serieVagaoViewModel)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    _serieVagaoAppService.Adicionar(serieVagaoViewModel);
                    return RedirectToAction("Index");
                }

                return View(serieVagaoViewModel);
            }

            return View(serieVagaoViewModel);
        }

        // GET: SeriesVagoes/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SerieVagaoViewModel serieVagaoViewModel = _serieVagaoAppService.ObterPorId(id.Value);
            if (serieVagaoViewModel == null)
            {
                return HttpNotFound();
            }

            ViewBag.ClasseVagaoId = new SelectList
                (
                    _serieVagaoAppService.ListaClassesVagoes(),
                    "ClasseVagaoId",
                    "Codigo",
                    serieVagaoViewModel.ClasseVagaoId
                );

            return View(serieVagaoViewModel);
        }

        // POST: SeriesVagoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SerieVagaoId,Codigo,Descricao,ClasseVagaoId")] SerieVagaoViewModel serieVagaoViewModel)
        {
            if (ModelState.IsValid)
            {
                _serieVagaoAppService.Atualizar(serieVagaoViewModel);
                return RedirectToAction("Index");
            }
            return View(serieVagaoViewModel);
        }

        // GET: SeriesVagoes/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ferrovia = _serieVagaoAppService.ObterPorId(id.Value);
            if (ferrovia == null)
            {
                return HttpNotFound();
            }
            return View(ferrovia);
        }

        // POST: SeriesVagoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _serieVagaoAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _serieVagaoAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
