namespace Cafe.Mortgage.Api.ServiceInterface.Data.Entities
{
    public class Disposition
    {
        public int Disp_Id { get; set; }
        public int DispClass_Id { get; set; }
        public string Disp_c { get; set; }
        public string Disposition_Desc { get; set; }
        public int Disp_Mask { get; set; }
        public int Disp_Type { get; set; }
        public int Display_f { get; set; }
        public int Abandon_f { get; set; }
        public int CallBack_f { get; set; }
        public int Contact_f { get; set; }
        public int FollowUp_f { get; set; }
        public int Sales_f { get; set; }
        public int MediaTypeMask { get; set; }
        public int Exclusions_f { get; set; }
        public int Refusal_f { get; set; }
        public int ContactClass { get; set; }
    }
}
