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
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarRequest(string comentario)
        {
            var meiosPagamentos = new MeiosPagamentosDAO().GetMeiosPagamentos();

            ViewBag.Pagamentos = meiosPagamentos;

            return RedirectToAction("Index", "Avaliacao");
        }

    }
}