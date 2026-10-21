using ServiceStack;
using ServiceStack.DataAnnotations;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
    public class GetAccount : IReturn<GetAccountResponse>
    {
        [Required]
        [DataMember(Order = 1)]
        public int ServiceId { get; set; }
        [Required]
        [DataMember(Order = 2)]
        public string AccountNo { get; set; }
        [Required]
        [DataMember(Order = 3)]
        public string TableName { get; set; }
    }

    [DataContract]
    public class GetAccountResponse
    {
        [DataMember(Order = 1)]
        public bool Success { get; set; } = true;
        [DataMember(Order = 2)]
        public string ErrorMessage { get; set; } = string.Empty;
        [DataMember(Order = 3)]
        public string TableName { get; set; }
        [DataMember(Order = 4)]
        public List<Metadata> Metadata { get; set; } = new List<Metadata>();
        public ResponseStatus ResponseStatus { get; set; }
    }
}