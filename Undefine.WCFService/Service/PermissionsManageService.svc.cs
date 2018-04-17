using Serialize.Linq.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Undefine.Domain.IRepository;
using Undefine.Domain.Model;
using Undefine.DtoModel;
using Undefine.WCFService.Base;

namespace Undefine.WCFService.Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“PermissionsManageService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 PermissionsManageService.svc 或 PermissionsManageService.svc.cs，然后开始调试。
    public class PermissionsManageService :BaseService ,IPermissionsManageService
    {
        public ISys_UserRepository ISysUserREP { get; set; }

        #region Constust
        public PermissionsManageService()
        {
        }
        public PermissionsManageService(ISys_UserRepository IS_UserRep)
        {
            ISysUserREP = IS_UserRep;
        }
        #endregion
        public List<Sys_UserInfo> GetUsers(ExpressionNode expressionNode)
        {
            Expression<Func<Sys_UserInfo, bool>> selector = null;
            if (expressionNode != null)
            {
                selector = expressionNode.ToExpression<Func<Sys_UserInfo, bool>>();
            }
            var lstRes = base.GetDtoByLamada<Sys_UserInfo, Sys_User>(ISysUserREP, selector);
            return lstRes;
        }
    }
}
