namespace Undefine.Domain.Model
{
    /// <summary>
    /// 模块操作元素
    /// </summary>
    public partial class Sys_ModuleElement:EditorEntity
    {
        public Sys_ModuleElement()
        {
            Name = string.Empty;
            DomId = string.Empty;
            Icon = string.Empty;
            BgColor = string.Empty;
            Remark = string.Empty;
            Sort = 99;
            ModuleId = string.Empty;
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 元素Id
        /// </summary>
        public string DomId { get; set; } 
        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 背景色
        /// </summary>
        public string BgColor { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public  int Sort { get; set; }
        /// <summary>
        /// 所属模块
        /// </summary>
        public string ModuleId { get; set; }
    }
}
