using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
    public class AddressMetadata
    {
        [DataMember(Order = 1)]
        public string NEW_ADDRESS_L1 { get; set; }
        [DataMember(Order = 2)]
        public string NEW_ADDRESS_L2 { get; set; }
        [DataMember(Order = 3)]
        public string NEW_ADDRESS_L3 { get; set; }
        [DataMember(Order = 4)]
        public string NEW_CITY { get; set; }
        [DataMember(Order = 5)]
        public string NEW_PHONE1 { get; set; }
        [DataMember(Order = 6)]
        public string NEW_PHONE2 { get; set; }
        [DataMember(Order = 7)]
        public string NEW_MOBILE { get; set; }
    }
}
