using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Undefine.Domain.IRepository;
using Undefine.Domain.Model;
using Undefine.DtoModel;

namespace Undefine.App
{
    public class UserManagerApp:BaseApplication
    {
        public ISys_UserRepository IS_UserRep { get; set; }
        public UserManagerApp(ISys_UserRepository IS_UserRepository)
        {
            IS_UserRep = IS_UserRepository;
        }

        public List<Sys_UserInfo> GetUsers(Expression<Func<Sys_UserInfo, bool>> expressionNode)
        {
            Expression<Func<Sys_UserInfo, bool>> selector = null;
            if (expressionNode != null)
            {
                selector =expressionNode;
            }
            var lstRes = base.GetDtoByLamada<Sys_UserInfo, Sys_User>(IS_UserRep, selector);
            return lstRes;
        }
    }
}
