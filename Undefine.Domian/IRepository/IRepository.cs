// ***********************************************************************
// Assembly         : Undefine.Domain
// Author           : zjx
// Created          : 2018.3.23
//
// Last Modified By : zjx
// Last Modified On : 2018.3.23
// *********************************************************************** 
// <summary>仓储接口</summary>
// ***********************************************************************
using System; 
using System.Linq;
using System.Linq.Expressions; 

namespace Undefine.Domain.IRepository
{
    public partial interface IRepository<T> where T : class
    {
        #region 查询
        /// <summary>
        ///     获取 当前实体的查询数据集
        /// </summary>
        IQueryable<T> Entities { get; }

        T FindSingle(Expression<Func<T, bool>> exp = null);
        bool IsExist(Expression<Func<T, bool>> exp);
        IQueryable<T> Find(Expression<Func<T, bool>> exp = null);
        IQueryable<T> Find(int pageindex = 1, int pagesize = 10, Func<T, object> orderBy= null,
            Expression<Func<T, bool>> exp = null);

        int GetCount(Expression<Func<T, bool>> exp = null);
        #endregion

        #region 新增
        int Insert(T entity);

        //void BatchInsert(T[] entities);
        #endregion 

        #region 更改
        /// <summary>
        /// 按指定的ID进行批量更新
        /// </summary>
        //int Update(Expression<Func<T, object>> identityExp, T entity);

        /// <summary>
        /// 实现按需要只更新部分更新
        /// <para>如：Update(u =>u.Id==1,u =>new User{Name="ok"});</para>
        /// </summary>
        /// <param name="where">更新条件</param>
        /// <param name="entity">更新后的实体</param>
        //int Update(Expression<Func<T, bool>> where, Expression<Func<T, T>> entity);
        /// <summary>
        /// 更新一个实体的所有属性
        /// </summary>
        int Update(T entity);
        #endregion

        #region 删除
        int Delete(T entity);

        /// <summary>
        /// 批量删除
        /// </summary>
        int Delete(Expression<Func<T, bool>> exp);
        #endregion

        //void Save();
    }
}
