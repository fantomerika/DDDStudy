// ***********************************************************************
// Assembly         : Undefine.Domain
// Author           : zjx
// Created          : 2018.3.23
// ***********************************************************************
// Last Modified By : zjx
// Last Modified On : 2018.3.23
// *********************************************************************** 
// <summary>工作单元接口</summary>
// ***********************************************************************
using System;
using System.Linq;
using System.Linq.Expressions;
using Undefine.Domain.Model;

namespace Undefine.Domain.IRepository
{
    public interface IUnitOfWork
    {
        #region 属性

        /// <summary>
        /// 获取 当前单元操作是否已被提交
        /// </summary>
        bool IsCommitted { get; set; }

        #endregion

        #region 方法
        /// <summary>
        /// 提交当前单元操作的结果
        /// </summary>
        /// <returns></returns>
        int Commit();

        /// <summary>
        /// 把当前单元操作回滚成未提交状态
        /// </summary>
        void Rollback();

        #endregion
    }
}
