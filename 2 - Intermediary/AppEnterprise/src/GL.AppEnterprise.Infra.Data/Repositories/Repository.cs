using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using GL.AppEnterprise.Domain.Interfaces.Repository;
using GL.AppEnterprise.Infra.Data.Context;

namespace GL.AppEnterprise.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected AppEnterpriseContext Db;

        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new AppEnterpriseContext();

            DbSet = Db.Set<TEntity>(); //aqui estamos criando um atalho para deixar o código mais clean na hora da implementação
        }

        public virtual TEntity Add(TEntity obj)
        {
            var returnObj = DbSet.Add(obj);
            SaveChanges();

            return returnObj;
        }

        public virtual void Delete(Guid id)
        {
            //Primeiro fazemos uma busca pelo id e depois removeremos.
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

        public virtual IEnumerable<TEntity> GetAll() //int t, int s (parâmetros para trabalhar com paginação em memória)
        {
            //return DbSet.Take(t).Skip(s).ToList(); //aqui um exemplo de paginação em memória
            return DbSet.ToList();
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual TEntity Update(TEntity obj)
        {
            var entry = Db.Entry(obj); //aqui estamos recebendo os dados alterados pelo usuário
            DbSet.Attach(obj); //aqui estamos recebendo os dados já inseridos no DB
            entry.State = EntityState.Modified; //aqui iremos modificar somente os campos que foi alterado
            SaveChanges(); //realizará a atualização

            return obj;
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this); //GC = Garbage Collector irá remover o lixo da app
        }
    }
}