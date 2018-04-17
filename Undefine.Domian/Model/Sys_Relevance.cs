namespace Undefine.Domain.Model
{
    public class Sys_Relevance:Entity
    {
        public Sys_Relevance()
        {
            FirstId = string.Empty;
            SecondId = string.Empty;
        }
        public string Key { get; set; }
        public string FirstId{ get; set; }
        public string SecondId { get; set; }
    }
}