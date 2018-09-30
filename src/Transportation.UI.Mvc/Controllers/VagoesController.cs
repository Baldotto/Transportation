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
    public class VagoesController : Controller
    {
        
        private readonly IVagaoAppService _vagaoAppService;
        private readonly ISerieVagaoAppService _serieVagaoAppService;
        private readonly IFerroviaAppService _ferroviaAppService;

        public VagoesController(IVagaoAppService vagaoAppService,
            ISerieVagaoAppService serieVagaoAppService,
            IFerroviaAppService ferroviaAppService)
        {
            _vagaoAppService = vagaoAppService;
            _serieVagaoAppService = serieVagaoAppService;
            _ferroviaAppService = ferroviaAppService;
        }

        // GET: Vagoes
        public ActionResult Index()
        {
            return View(_vagaoAppService.ObterTodos());
        }



        // GET: Vagoes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ferrovia = _vagaoAppService.ObterPorId(id.Value);

            if (ferrovia == null)
            {
                return HttpNotFound();
            }
            return View(ferrovia);
        }

        // GET: Vagoes/Create
        public ActionResult Create()
        {
            ViewBag.SerieVagaoId = new SelectList
                (
                    _serieVagaoAppService.ListaSerieVagoes(),
                    "SerieVagaoId",
                    "Codigo"
                );

            ViewBag.FerroviaOperadoraId = new SelectList
                (
                    _ferroviaAppService.ListaFerrovias(),
                    "FerroviaId",
                    "Codigo"
                );

            return View();
        }

        // POST: Vagoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VagaoId,DataCadastro,Ativo,Codigo,Bitola,QuantidadeEixos,CapacidadeNominal,Comprimento,Largura,Altura,ComprimentoUtil,LarguraUtil,VolumeMedio,DataFabricacao,Tara,FerroviaOperadoraId,SerieVagaoId")] VagaoViewModel vagaoViewModel)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    _vagaoAppService.Adicionar(vagaoViewModel);
                    return RedirectToAction("Index");
                }

                return View(vagaoViewModel);
            }

            return View(vagaoViewModel);
        }

        // GET: Vagoes/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VagaoViewModel vagaoViewModel = _vagaoAppService.ObterPorId(id.Value);
            if (vagaoViewModel == null)
            {
                return HttpNotFound();
            }


            ViewBag.SerieVagaoId = new SelectList
                (
                    _serieVagaoAppService.ListaSerieVagoes(),
                    "SerieVagaoId",
                    "Codigo",
                    vagaoViewModel.SerieVagaoId
                );

            ViewBag.FerroviaOperadoraId = new SelectList
                (
                    _ferroviaAppService.ListaFerrovias(),
                    "FerroviaId",
                    "Codigo",
                    vagaoViewModel.FerroviaOperadoraId
                );

            return View(vagaoViewModel);
        }

        // POST: Vagoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VagaoId,DataCadastro,Ativo,Codigo,Bitola,QuantidadeEixos,CapacidadeNominal,Comprimento,Largura,Altura,ComprimentoUtil,LarguraUtil,VolumeMedio,DataFabricacao,Tara,FerroviaOperadoraId,SerieVagaoId")] VagaoViewModel vagaoViewModel)
        {
            if (ModelState.IsValid)
            {
                _vagaoAppService.Atualizar(vagaoViewModel);
                return RedirectToAction("Index");
            }
            return View(vagaoViewModel);
        }

        // GET: Vagoes/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ferrovia = _vagaoAppService.ObterPorId(id.Value);
            if (ferrovia == null)
            {
                return HttpNotFound();
            }
            return View(ferrovia);
        }

        // POST: Vagoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _vagaoAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _vagaoAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
