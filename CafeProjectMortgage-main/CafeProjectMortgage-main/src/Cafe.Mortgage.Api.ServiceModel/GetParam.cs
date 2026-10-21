using ServiceStack;
using ServiceStack.DataAnnotations;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
    public class GetParam : IReturn<GetParamResponse>
    {
        [Required]
        [DataMember(Order = 1)]
        public string ParamName { get; set; }
        [DataMember(Order = 2)]
        public string ParamType { get; set; }
    }

    [DataContract]
    public class GetParamResponse
    {
        [DataMember(Order = 1)]
        public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();
        [DataMember(Order = 2)]
        public ResponseStatus ResponseStatus { get; set; }
    }
}
