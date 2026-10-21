using ServiceStack;
using ServiceStack.DataAnnotations;
using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
    public class UpdateAccount : IReturn<UpdateAccountResponse>
    {
        [Required]
        [DataMember(Order = 1)]
        public string Action { get; set; }
        [Required]
        [DataMember(Order = 2)]
        public string TableName { get; set; }
        [Required]
        [DataMember(Order = 3)]
        public string AccountNo { get; set; }
        [DataMember(Order = 4)]
        public string AccountNo1 { get; set; }
        [DataMember(Order = 5)]
        public string AccountNo2 { get; set; }
        [Required]
        [DataMember(Order = 6)]
        public UpdateAccountMetadata Data { get; set; }
        [Required]
        [DataMember(Order = 7)]
        public bool IsPrev { get; set; }
    }

    [DataContract]
    public class UpdateAccountResponse
    {
        [DataMember(Order = 1)]
        public bool Success { get; set; } = true;
        [DataMember(Order = 2)]
        public string ErrorMessage { get; set; } = string.Empty;
        public ResponseStatus ResponseStatus { get; set; }
    }
}