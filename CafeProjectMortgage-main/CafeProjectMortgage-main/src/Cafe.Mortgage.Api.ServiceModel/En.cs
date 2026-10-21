using ServiceStack;
using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
    public class En : IReturn<EnResponse>
    {
        [DataMember(Order = 1)]
        public string Text { get; set; }
    }
    [DataContract]
    public class EnResponse
    {
        [DataMember(Order = 1)]
        public string Result { get; set; }
    }
}