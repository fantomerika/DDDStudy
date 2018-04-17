using System;
using Undefine.Domain.Enum;
namespace Undefine.Domain.Model
{
    /// <summary>
    /// 系统用户
    /// </summary>
    public class Sys_User : EditorEntity
    {
        public Sys_User()
        {
            UserName = string.Empty;
            Account = string.Empty;
            PassWord = string.Empty;
            Sex = (int)Sys_User_SexEnum.secrecy;
            Status = (int)Sys_User_StatusEnum.normal;
            LastLoginIp = string.Empty;
            LastLoginTime = DateTime.Now;
        }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 登录账户
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary> 
        public string PassWord { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 用户状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 上次登录Ip
        /// </summary>
        public string LastLoginIp { get; set; }
        /// <summary>
        /// 上次登录日期
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        public string SexText()
        {
            switch ((Sys_User_SexEnum)Sex)
            {
                case Sys_User_SexEnum.male:
                    return "男";
                case Sys_User_SexEnum.famale:
                    return "女";
                case Sys_User_SexEnum.secrecy:
                    return "保密";
                default:
                    return "未填写";
            }
        }
        public string StatusText()
        {
            switch ((Sys_User_StatusEnum)Status)
            {
                case Sys_User_StatusEnum.normal:
                    return "正常";
                case Sys_User_StatusEnum.ban:
                    return "禁用";
                case Sys_User_StatusEnum.abnormal:
                    return "异常";
                default:
                    return "未填写";
            }
        }
    }
}
