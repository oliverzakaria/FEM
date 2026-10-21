using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
    public class OtherMetadata
    {
        [DataMember(Order = 1)]
        public string INPUT_CONTACT_PLACE1 { get; set; }
        [DataMember(Order = 2)]
        public string IN_PERSON_CONTACT1 { get; set; }
        [DataMember(Order = 3)]
        public string INPUT_REMARKS1 { get; set; }
        [DataMember(Order = 4)]
        public string ACTION2 { get; set; }
        [DataMember(Order = 5)]
        public string ACTION3 { get; set; }
        [DataMember(Order = 6)]
        public decimal PTPAMOUNT { get; set; }
        [DataMember(Order = 7)]
        public string PTPDATE { get; set; }
        [DataMember(Order = 8)]
        public decimal PTPAMOUNT2 { get; set; }
        [DataMember(Order = 9)]
        public string PTPDATE2 { get; set; }
        [DataMember(Order = 10)]
        public decimal PTPAMOUNT3 { get; set; }
        [DataMember(Order = 11)]
        public string PTPDATE3 { get; set; }
    }
}
