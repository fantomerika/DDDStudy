namespace Undefine.Domain.Model
{
    /// <summary>
    /// 角色
    /// </summary>
    public  class Sys_Role:EditorEntity
    {
        public Sys_Role()
        {
            Name = string.Empty;
        }
        /// <summary>
        /// 角色名
        /// </summary>
        public string Name { get; set; }

    }
}
