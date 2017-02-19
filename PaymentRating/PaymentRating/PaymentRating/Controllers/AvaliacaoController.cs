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

        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.Pagamentos  = new DAO.MeiosPagamentosDAO().GetMeiosPagamentos();
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarRequest(string meioPag, string comentario, string sugestao, string Recomendar)
        {

            return RedirectToAction("Index", "Avaliacao");
        }
    }
}