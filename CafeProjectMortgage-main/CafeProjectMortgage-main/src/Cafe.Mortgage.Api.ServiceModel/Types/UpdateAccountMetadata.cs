using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
    public class UpdateAccountMetadata
    {
        [DataMember(Order = 1)]
        public AddressMetadata Address { get; set; }
        [DataMember(Order = 2)]
        public OtherMetadata Other { get; set; }
    }
}
