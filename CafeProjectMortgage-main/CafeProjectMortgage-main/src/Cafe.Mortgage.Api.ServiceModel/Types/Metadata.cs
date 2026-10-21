using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
	[DataContract]
	public class Metadata
	{
        [DataMember(Order = 1)]
        public string FieldName { get; set; }
        [DataMember(Order = 2)]
        public string FieldValue { get; set; }
        [DataMember(Order = 3)]
        public string FieldType { get; set; }
	}
}