using System;
using Undefine.Domain.IRepository;

namespace Undefine.Repository
{
    public interface IUnitOfWorkRepositoryContext : IUnitOfWork, IDisposable
    {
        /// <summary>
        /// 将聚合根的状态标记为新建，但EF上下文此时并未提交
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="obj"></param>
        void RegisterNew<TEntity>(TEntity obj)
            where TEntity : class;

        /// <summary>
        /// 将聚合根的状态标记为修改，但EF上下文此时并未提交
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="obj"></param>
        void RegisterModified<TEntity>(TEntity obj)
            where TEntity : class;

        /// <summary>
        /// 将聚合根的状态标记为删除，但EF上下文此时并未提交
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="obj"></param>
        void RegisterDeleted<TEntity>(TEntity obj)
            where TEntity : class;
    }
}
