using PaymentRating.DAO;
using PaymentRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentRating.Controllers
{
    public class AvaliacaoController : Controller
    {
        // GET: Avaliacao
        public ActionResult Index()
        {
            var avaliacoes = new AvaliacaoDAO().Listar();
       
            return View(avaliacoes);
        }

        [HttpPost]
        public ActionResult Cadastrar(Avaliacao avaliacao)
        {
            return RedirectToAction("Index", "Avaliacao");
        }

        
    }
}