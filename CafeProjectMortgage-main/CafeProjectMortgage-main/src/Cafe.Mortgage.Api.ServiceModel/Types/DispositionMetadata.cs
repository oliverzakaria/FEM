using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
    public class DispositionMetadata
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Description { get; set; }
        [DataMember(Order = 3)]
        public string Type { get; set; }
        [DataMember(Order = 4)]
        public string Code { get; set; }
    }
}