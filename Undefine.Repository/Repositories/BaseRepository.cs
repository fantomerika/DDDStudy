using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using Undefine.Domain.IRepository;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Undefine.Repository.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IEFUnitOfWork UnitOfWork { get; set; }

        public BaseRepository(IEFUnitOfWork uow)
        {
            UnitOfWork = uow;
        }

        public IQueryable<TEntity> Entities => UnitOfWork.Context.Set<TEntity>().AsNoTracking() as IQueryable<TEntity>;

        public int Delete(TEntity entity)
        {
            UnitOfWork.RegisterDeleted(entity);
            return UnitOfWork.Commit();
        }

        public int Delete(Expression<Func<TEntity, bool>> exp)
        {
            UnitOfWork.RegisterDeleted(Find(exp));
            return UnitOfWork.Commit();
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> exp = null)
        {
            return Filter(exp);
        }

        public IQueryable<TEntity> Find(int pageindex = 1, int pagesize = 10, Func<TEntity, object> orderby = null, Expression<Func<TEntity, bool>> exp = null)
        {
            if (pageindex < 1) pageindex = 1;
            return Filter(exp).OrderBy(orderby).Skip(pagesize * (pageindex - 1)).Take(pagesize).AsQueryable();
        }

        public TEntity FindSingle(Expression<Func<TEntity, bool>> exp = null)
        {
            return UnitOfWork.Context.Set<TEntity>().AsNoTracking().FirstOrDefault(exp);
        }

        public int GetCount(Expression<Func<TEntity, bool>> exp = null)
        {
            return Filter(exp).Count();
        }

        public int Insert(TEntity entity)
        {
            UnitOfWork.RegisterNew(entity);
            return UnitOfWork.Commit();
        }

        public bool IsExist(Expression<Func<TEntity, bool>> exp)
        {
            return UnitOfWork.Context.Set<TEntity>().Any(exp);
        }


        public int Update(TEntity entity)
        {
            UnitOfWork.RegisterModified(entity);
            return UnitOfWork.Commit();
        }

        private IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> exp)
        {
            var dbSet = UnitOfWork.Context.Set<TEntity>().AsQueryable();
            if (exp != null)
                dbSet = dbSet.Where(exp);
            return dbSet;
        }
    }
}
