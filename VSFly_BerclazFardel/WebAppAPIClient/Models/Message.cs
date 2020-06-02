using System.Runtime.Serialization;

namespace WebAppAPIClient.Models
{
    [DataContract]
    public class Message<T>
    {
        [DataMember(Name = "isSuccess")]
        public bool isSuccess { get; set; }

        [DataMember(Name = "ReturnMessage")]
        public string ReturnMessage { get; set; }

        [DataMember(Name = "Data")]
        public T Data { get; set; }
    }
}
