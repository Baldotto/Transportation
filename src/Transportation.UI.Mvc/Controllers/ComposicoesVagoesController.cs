using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Transportation.Application.ViewModels;
using Transportation.UI.Mvc.Models;

namespace Transportation.UI.Mvc.Controllers
{
    public class ComposicoesVagoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ComposicoesVagoes
        public ActionResult Index()
        {
            var composicaoVagaoViewModels = db.ComposicaoVagaoViewModels.Include(c => c.Composicao).Include(c => c.Vagao);
            return View(composicaoVagaoViewModels.ToList());
        }

        // GET: ComposicoesVagoes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComposicaoVagaoViewModel composicaoVagaoViewModel = db.ComposicaoVagaoViewModels.Find(id);
            if (composicaoVagaoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(composicaoVagaoViewModel);
        }

        // GET: ComposicoesVagoes/Create
        public ActionResult Create()
        {
            ViewBag.ComposicaoId = new SelectList(db.ComposicaoViewModels, "ComposicaoId", "ComposicaoId");
            ViewBag.VagaoId = new SelectList(db.VagaoViewModels, "VagaoId", "Codigo");
            return View();
        }

        // POST: ComposicoesVagoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComposicaoVagaoId,ComposicaoId,VagaoId,DataCadastro")] ComposicaoVagaoViewModel composicaoVagaoViewModel)
        {
            if (ModelState.IsValid)
            {
                composicaoVagaoViewModel.ComposicaoVagaoId = Guid.NewGuid();
                db.ComposicaoVagaoViewModels.Add(composicaoVagaoViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ComposicaoId = new SelectList(db.ComposicaoViewModels, "ComposicaoId", "ComposicaoId", composicaoVagaoViewModel.ComposicaoId);
            ViewBag.VagaoId = new SelectList(db.VagaoViewModels, "VagaoId", "Codigo", composicaoVagaoViewModel.VagaoId);
            return View(composicaoVagaoViewModel);
        }

        // GET: ComposicoesVagoes/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComposicaoVagaoViewModel composicaoVagaoViewModel = db.ComposicaoVagaoViewModels.Find(id);
            if (composicaoVagaoViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.ComposicaoId = new SelectList(db.ComposicaoViewModels, "ComposicaoId", "ComposicaoId", composicaoVagaoViewModel.ComposicaoId);
            ViewBag.VagaoId = new SelectList(db.VagaoViewModels, "VagaoId", "Codigo", composicaoVagaoViewModel.VagaoId);
            return View(composicaoVagaoViewModel);
        }

        // POST: ComposicoesVagoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComposicaoVagaoId,ComposicaoId,VagaoId,DataCadastro")] ComposicaoVagaoViewModel composicaoVagaoViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(composicaoVagaoViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ComposicaoId = new SelectList(db.ComposicaoViewModels, "ComposicaoId", "ComposicaoId", composicaoVagaoViewModel.ComposicaoId);
            ViewBag.VagaoId = new SelectList(db.VagaoViewModels, "VagaoId", "Codigo", composicaoVagaoViewModel.VagaoId);
            return View(composicaoVagaoViewModel);
        }

        // GET: ComposicoesVagoes/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComposicaoVagaoViewModel composicaoVagaoViewModel = db.ComposicaoVagaoViewModels.Find(id);
            if (composicaoVagaoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(composicaoVagaoViewModel);
        }

        // POST: ComposicoesVagoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            ComposicaoVagaoViewModel composicaoVagaoViewModel = db.ComposicaoVagaoViewModels.Find(id);
            db.ComposicaoVagaoViewModels.Remove(composicaoVagaoViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
