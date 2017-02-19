using PaymentRating.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentRating.Controllers
{
    public class RankingController : Controller
    {
        // GET: Ranking
        public ActionResult Index()
        {
            var avaliacoes = new AvaliacaoDAO().Listar();

            return View(avaliacoes);
        }
    }
}