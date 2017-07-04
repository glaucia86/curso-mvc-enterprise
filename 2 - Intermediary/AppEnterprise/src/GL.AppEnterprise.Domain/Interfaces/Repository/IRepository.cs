using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GL.AppEnterprise.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);

        TEntity GetById(Guid id);

        IEnumerable<TEntity> GetAll();

        TEntity Update(TEntity obj);

        void Delete(Guid id);

        //Método responsável por realizar uma busca genérica no banco
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);

        //Método que salva infos no banco através do Entity Framework
        int SaveChanges();
    }
}