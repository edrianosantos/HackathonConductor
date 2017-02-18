using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaymentRating.Context;

namespace PaymentRating.DAO
{
    public abstract class DAO<TEntity> : IDisposable where TEntity : class
    {
        protected BancoContext db = new BancoContext();
        public void Adicionar(TEntity objeto)
        { db.Set<TEntity>().Add(objeto); }
        public void Excluir(Func<TEntity, bool> predicate) { db.Set<TEntity>().Where(predicate).ToList().ForEach(del => db.Set<TEntity>().Remove(del)); }
        public void Atualizar(TEntity objeto) { db.Entry(objeto).State = System.Data.Entity.EntityState.Modified; }
        public void Salvar() { db.SaveChanges(); }
        public IQueryable Listar() { return db.Set<TEntity>(); }
        public TEntity ListarPorId(params object[] Id) { return db.Set<TEntity>().Find(Id); }
        public void Dispose() { db.Dispose(); }
    }
}
