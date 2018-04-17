using Serialize.Linq.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Undefine.DtoModel;

namespace Undefine.WCFService.Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IPermissionsManageService”。
    [ServiceContract]
    public interface IPermissionsManageService
    {  
        //用户管理
        [OperationContract]
        List<Sys_UserInfo> GetUsers(ExpressionNode expressionNode);
    }
}
