namespace Undefine.Domain.Model
{
    /// <summary>
    /// 功能模块
    /// </summary>
    public class Sys_Module:EditorEntity
    {
        public Sys_Module()
        {
            Name = string.Empty;
            Url = string.Empty;
            Icon = string.Empty;
            Sort = 99;
            IsAutoExpand = false;
            ParentId = string.Empty;
            ParentName = string.Empty;
            Enabled = 1;
        }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 跳转路径
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 使用图标
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 是否自动展开
        /// </summary>
        public bool IsAutoExpand { get; set; }
        /// <summary>
        /// 父节点Id
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// 父节点名称
        /// </summary>
        public string ParentName { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int Enabled { get; set; }
    }
}
