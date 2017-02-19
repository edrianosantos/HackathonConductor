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
            if (Session["usuario"] == null)
            {
                TempData["msg-error"] += "Você não tem permissão para acessar essa tela!";
                return RedirectToAction("Login", "Login");
            }

            ViewBag.Pagamentos  = new DAO.MeiosPagamentosDAO().GetMeiosPagamentos();
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarRequest(Avaliacao avaliacao)
        {
            if (Session["usuario"] == null)
            {
                TempData["msg-error"] += "Você não tem permissão para acessar essa tela!";
                return RedirectToAction("Login", "Login");
            }

            if (string.IsNullOrEmpty(avaliacao.Comentario))
            {
                TempData["msg-error"] += "Preencha todos os campos!";
                return RedirectToAction("Cadastrar", "Avaliacao");
            }

            var user = Session["usuario"] as Usuario;
            avaliacao.Data = DateTime.Now;
            avaliacao.IdUsuario = user.Id;

            new AvaliacaoDAO().SalvarAvaliacao(avaliacao);

            return RedirectToAction("Index", "Avaliacao");
        }
    }
}