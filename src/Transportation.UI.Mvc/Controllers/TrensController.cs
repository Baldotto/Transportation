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
    public class TrensController : Controller
    {
        private readonly ITremAppService _tremAppService;
        private readonly IVagaoAppService _vagaoAppService;
        private readonly IComposicaoVagaoAppService _composicaoVagaoAppService;
        private readonly IComposicaoAppService _composicaoAppService;

        public TrensController(ITremAppService tremAppService, IVagaoAppService vagaoAppService, 
            IComposicaoVagaoAppService composicaoVagaoAppService, IComposicaoAppService composicaoAppService)
        {
            _tremAppService = tremAppService;
            _vagaoAppService = vagaoAppService;
            _composicaoVagaoAppService = composicaoVagaoAppService;
            _composicaoAppService = composicaoAppService;

        }

        // GET: Trens
        public ActionResult Index()
        {
            return View(_tremAppService.ObterTodos());
        }

        public ActionResult ListaVagoesAnexar(Guid? id)
        {
            ViewBag.IdTrem = id;
            return View(_vagaoAppService.ObterTodos());
        }

        public ActionResult BuscarAnexados(Guid? id)
        {

            return View(_composicaoVagaoAppService.ObterTodos());
        }

        public ActionResult AnexarVagoes(Guid? id)
        {
            ViewBag.ID = id;
            return View(_tremAppService.ObterTodos());
        }

        public ActionResult ExecutarAnexacao(Guid? idTrem , Guid? idVagao)
        {
            ComposicaoVagaoViewModel composicaoVagao = new ComposicaoVagaoViewModel();
            ComposicaoViewModel composicao = new ComposicaoViewModel();
            composicao = _composicaoAppService.ObterPorTremId(idTrem.Value);

            composicaoVagao.VagaoId = idVagao.Value;
            composicaoVagao.ComposicaoId = composicao.ComposicaoId;

            _composicaoVagaoAppService.Adicionar(composicaoVagao);

            return View(_tremAppService.ObterTodos());
        }

        

        // GET: Trens/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var trem = _tremAppService.ObterPorId(id.Value);

            if (trem == null)
            {
                return HttpNotFound();
            }
            return View(trem);
        }

        // GET: Trens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TremId,Prefixo,OS")] TremViewModel tremViewModel)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    _tremAppService.Adicionar(tremViewModel);
                    return RedirectToAction("Index");
                }

                return View(tremViewModel);
            }

            return View(tremViewModel);
        }

        // GET: Trens/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TremViewModel tremViewModel = _tremAppService.ObterPorId(id.Value);
            if (tremViewModel == null)
            {
                return HttpNotFound();
            }


            

            return View(tremViewModel);
        }

        // POST: Trens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TremId,Prefixo,OS")] TremViewModel tremViewModel)
        {
            if (ModelState.IsValid)
            {
                _tremAppService.Atualizar(tremViewModel);
                return RedirectToAction("Index");
            }
            return View(tremViewModel);
        }

        // GET: Trens/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var trem = _tremAppService.ObterPorId(id.Value);
            if (trem == null)
            {
                return HttpNotFound();
            }
            return View(trem);
        }

        // POST: Trens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _tremAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _tremAppService.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
