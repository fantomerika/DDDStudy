using System;
using System.Collections.Generic;
using System.Text;

namespace Undefine.Domain.Enum
{
    public enum Sys_User_StatusEnum
    {
        /// <summary>
        /// 正常状态
        /// </summary>
        normal=1,
        /// <summary>
        /// 被禁用
        /// </summary>
        ban =-1,
        /// <summary>
        /// 状态异常
        /// </summary>
        abnormal=-2
    }
}
