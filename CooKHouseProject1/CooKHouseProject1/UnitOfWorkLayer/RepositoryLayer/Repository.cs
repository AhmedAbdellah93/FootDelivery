using CookHouseDB.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Repository
{
      class Repository<TEntity> : IRepository<TEntity> where TEntity : class
       {
        protected readonly RestaurantContext Context;
        /* Return Dbset From TEntity*/
        protected DbSet<TEntity> DbSet
        {
            get
            {
                return Context.Set<TEntity>();
            }
        }
        
         public  Repository(RestaurantContext context)
        {
            Context = context;
        }
        public int Count
        {
            get
            {
                return DbSet.Count();
            }
        }

        public TEntity Create(TEntity t)
        {
            var newEntry = DbSet.Add(t);          
            return newEntry;
        }
        public IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate).AsEnumerable<TEntity>();
        }
        public void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            var objects = Filter(predicate);
            foreach (var obj in objects)
                DbSet.Remove(obj);
        }

        public void Delete(TEntity t)
        {
            DbSet.Remove(t);
        }

        
        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.AsEnumerable<TEntity>();
        }

        public void Update(TEntity t)
        {
            var entry = Context.Entry(t);
            DbSet.Attach(t);
            entry.State = EntityState.Modified;
        }
    }
}
