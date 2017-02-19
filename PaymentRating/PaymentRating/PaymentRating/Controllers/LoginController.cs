using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using PaymentRating.Models;

namespace PaymentRating.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginResult(string email, string senha)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(string nome, string email, string senha)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                TempData["msg-error"] += "Preencha todos os campos!";
                return View();
            }

            var md5 = Util.MD5.GetMD5Hash(senha);
            var user = new Usuario() {Nome = nome, Email = email, Senha = md5};
            new DAO.UsuarioDAO().SalvarUsuario(user);
            TempData["msg-sucesso"] += "Preencha todos os campos!";

            return RedirectToAction("Index", "Home");
        }


    }
}