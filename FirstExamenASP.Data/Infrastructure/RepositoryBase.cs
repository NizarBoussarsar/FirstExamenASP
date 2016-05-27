﻿using FirstExamenASP.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Data.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private FirstExamenASPDB dataContext;
        private IDbSet<T> dbset;
        IDatabaseFactory databaseFactory;
        protected RepositoryBase(DatabaseFactory dbFactory)
        {
            this.databaseFactory = dbFactory;
            dbset = DataContext.Set<T>();
        }
        protected FirstExamenASPDB DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        public virtual IQueryable<T> GetAll()
        {
            return dbset;
        }
        public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where);
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }
    }

}
