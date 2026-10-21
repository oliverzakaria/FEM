using ServiceStack;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
    public class GetDisposition : IReturn<GetDispositionResponse>
    {
    }

    [DataContract]
    public class GetDispositionResponse
    {
        [DataMember(Order = 1)]
        public bool Success { get; set; } = true;
        [DataMember(Order = 2)]
        public string ErrorMessage { get; set; } = string.Empty;
        [DataMember(Order = 3)]
        public List<DispositionMetadata> Data { get; set; } = new List<DispositionMetadata>();
        public ResponseStatus ResponseStatus { get; set; }
    }
}