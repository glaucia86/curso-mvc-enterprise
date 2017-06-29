using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GL.AppEnterprise.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        /// <summary>
        /// Método responsável por Adicionar um dado
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        TEntity Add(TEntity obj);

        /// <summary>
        /// Método responsável por realizar busca pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(Guid id);

        /// <summary>
        /// Método responsável por retornar todos os dados
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Método responsável por Atualizar os dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        TEntity Update(TEntity obj);

        /// <summary>
        /// Método responsável por Excluir um dado
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);

        /// <summary>
        /// Método responsável por realizar uma busca genérica no banco
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Método que salva infos no banco através do Entity Framework
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}