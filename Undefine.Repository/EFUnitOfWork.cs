using Microsoft.EntityFrameworkCore;
using Undefine.Repository.Models;

namespace Undefine.Repository
{
    public class EFUnitOfWork : IEFUnitOfWork
    { 

        public DbContext Context { get { return EFContext; } }

        public DbContext EFContext { get; set; }

        public EFUnitOfWork(DbContext context)
        {
            EFContext = context;
            EFContext.ChangeTracker.AutoDetectChangesEnabled = false;//实体跟踪禁用
        }

        #region IUnitOfWorkRepositoryContext接口
        public void RegisterNew<TEntity>(TEntity obj) where TEntity:class
        {
            //Context.Entry<TEntity>(obj).State;
            var state = Context.Entry(obj).State;
            if (state == EntityState.Detached)
            {
                Context.Entry(obj).State = EntityState.Added;
            }
            IsCommitted = false;
        }

        public void RegisterModified<TEntity>(TEntity obj) where TEntity : class
        {
            if (Context.Entry(obj).State == EntityState.Detached)
            {
                //context.Set<TEntity>().Attach(obj);
            }
            Context.Entry(obj).State = EntityState.Modified;
            IsCommitted = false;
        }

        public void RegisterDeleted<TEntity>(TEntity obj) where TEntity : class
        {
            Context.Entry(obj).State = EntityState.Deleted;
            IsCommitted = false;
        }
        #endregion 

        #region IUnitOfWork接口
        public bool IsCommitted { get; set; }
        public int Commit()
        {
            if (IsCommitted)
            {
                return 0;
            }
            try
            {
                int result = Context.SaveChanges();
                IsCommitted = true;
                return result;
            }
            catch (DbUpdateException e)
            {

                throw e;
            }
        }

        public void Rollback()
        {
            IsCommitted = false;
        }
        #endregion

        #region IDisposable接口 
        public void Dispose()
        {
            if (!IsCommitted)
            {
                Commit();
            }
            Context.Dispose();
        }
        #endregion
    }
}
