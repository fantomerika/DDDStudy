// ***********************************************************************
// Assembly         : Undefine.Domain
// Author           : zjx
// Created          : 2018.3.23
//
// Last Modified By : zjx
// Last Modified On : 2018.3.23
// *********************************************************************** 
// <summary>用户仓储接口</summary>
// ***********************************************************************
using System.Collections.Generic;
using Undefine.Domain.Model;

namespace Undefine.Domain.IRepository
{
    /// <summary>
    /// 用户仓储接口
    /// </summary>
    public interface ISys_UserRepository:IRepository<Sys_User>
    {
        IEnumerable<Sys_User> GetUsers(int index, int size);

    }
}
