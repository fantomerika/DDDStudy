using System.Runtime.Serialization;

namespace Undefine.DtoModel
{
    [DataContract]
    public class Sys_UserInfo
    {
        [DataMember]
        public string USERNAME { get; set; }
        [DataMember]
        public string ID { get; set; }

    }
}
