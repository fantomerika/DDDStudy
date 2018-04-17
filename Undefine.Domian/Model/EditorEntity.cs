using System;

namespace Undefine.Domain.Model
{
    public abstract class EditorEntity : Entity
    {
        public EditorEntity()
        {
            CreationTime = DateTime.Now;
            ModifyTime = CreationTime;
        }

        #region 创建信息
        /// <summary>
        /// 创建用户Id
        /// </summary>
        public string CreationUserId { get; set; }
        /// <summary>
        /// 创建用户名
        /// </summary>
        public string CreationUserName { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreationTime { get; set; }
        #endregion

        #region 修改信息
        /// <summary>
        /// 修改用户Id
        /// </summary>
        public string ModifyUserId { get; set; }
        /// <summary>
        /// 修改用户名称
        /// </summary>
        public string ModifyUserName { get; set; }
        /// <summary>
        /// 修改用户日期
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        #endregion

    }
}
