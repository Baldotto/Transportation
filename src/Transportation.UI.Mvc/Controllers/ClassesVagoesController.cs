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
    public class ClassesVagoesController : Controller
    {
        private readonly IClasseVagaoAppService _classeVagaoAppService;

        public ClassesVagoesController(IClasseVagaoAppService classeVagaoAppService)
        {
            _classeVagaoAppService = classeVagaoAppService;
        }

        // GET: ClassesVagoes
        public ActionResult Index()
        {
            return View(_classeVagaoAppService.ObterTodos());
        }

        // GET: ClassesVagoes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var classeVagao = _classeVagaoAppService.ObterPorId(id.Value);

            if (classeVagao == null)
            {
                return HttpNotFound();
            }
            return View(classeVagao);
        }

        // GET: ClassesVagoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassesVagoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClasseVagaoId,Codigo,Descricao")] ClasseVagaoViewModel classeVagaoViewModel)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    _classeVagaoAppService.Adicionar(classeVagaoViewModel);
                    return RedirectToAction("Index");
                }

                return View(classeVagaoViewModel);
            }

            return View(classeVagaoViewModel);
        }

        // GET: ClassesVagoes/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var classeVagao = _classeVagaoAppService.ObterPorId(id.Value);
            if (classeVagao == null)
            {
                return HttpNotFound();
            }
            return View(classeVagao);
        }

        // POST: ClassesVagoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClasseVagaoId,Codigo,Descricao")] ClasseVagaoViewModel classeVagaoViewModel)
        {
            if (ModelState.IsValid)
            {
                _classeVagaoAppService.Atualizar(classeVagaoViewModel);
                return RedirectToAction("Index");
            }
            return View(classeVagaoViewModel);
        }

        // GET: ClassesVagoes/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var classeVagao = _classeVagaoAppService.ObterPorId(id.Value);
            if (classeVagao == null)
            {
                return HttpNotFound();
            }
            return View(classeVagao);
        }

        // POST: ClassesVagoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _classeVagaoAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _classeVagaoAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
