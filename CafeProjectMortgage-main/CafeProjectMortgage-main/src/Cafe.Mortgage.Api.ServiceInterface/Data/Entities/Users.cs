namespace Cafe.Mortgage.Api.ServiceInterface.Data.Entities
{
    public class Users
    {
        public string User_Id { get; set; }

        public string User_L_Name { get; set; }
        public string User_F_Name { get; set; }
        public string Password { get; set; }
        public int UserTypeMask { get; set; }
        public int Disabled { get; set; }
        public string UserFullName { get; set; }
        public string EMailAddress { get; set; }
        public int EMailProtocolId { get; set; }
        public int PresentationIndicator { get; set; }
        public string CallingNumber { get; set; }
        public string FirstThreeDigitsOfLastName { get; set; }
        public string RMAccountId { get; set; }
        public string RMAccountPIN { get; set; }
        public int RMAccountEnabled { get; set; }
        public int UserNameMessageId { get; set; }
        public int UserNameLanguageId { get; set; }
        public int Application_Id { get; set; }
        public string CallingPartyName { get; set; }
        public string LDAPUserId { get; set; }
        public string PhoneNumber { get; set; }
        public string IMConnectSIPURL { get; set; }
        public string HomePhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string ExternalUserName { get; set; }
        public string OfficePhoneNumber { get; set; }
        public int AgentCtiId { get; set; } //IDENTITY

        public int TimeZone_Id { get; set; }
    }
}
