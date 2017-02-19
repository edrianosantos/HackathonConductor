using PaymentRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaymentRating.DAO;

namespace PaymentRating.DAO
{
    public class UsuarioDAO : DAO<Usuario>
    {
        public void SalvarUsuario(Usuario user)
        {
            Adicionar(user);
            Salvar();
        }

        public Usuario GetUsuarioLogin(string email, string senha)
        {
            return db.Usuario.Where(x => x.Email.Equals(email) && x.Senha.Equals(senha)).FirstOrDefault();
        }

    }
}