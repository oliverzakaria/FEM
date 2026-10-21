using System;

namespace Cafe.Mortgage.Api.ServiceInterface.Data.Entities
{
    public class Table_Stat
    {
        public int Table_Id { get; set; }

        public int TimeZone_Id { get; set; }
        public int Application_Id { get; set; }
        public int TableDef_Id { get; set; }
        public string Table_desc { get; set; }
        public string Table_status { get; set; }

        public DateTime Table_Orig_d { get; set; }

        public int Total_records { get; set; }

        public int Unresolved_records { get; set; }
        public int Callbacks { get; set; }
        public int Last_Record_Num { get; set; }
        public string SourceDSN { get; set; }
        public int Site_Id { get; set; }
        public int ServerId { get; set; }
        public int StoreManagerId { get; set; }
        public int TargetManagerId { get; set; }
        public int TrickleTable { get; set; }
        public int CallTableProcessing { get; set; }
        public int NextPassStartRecordNumber { get; set; }
        public int TableType { get; set; }
        public int DeleteCallBacksOnTableDelete { get; set; }
    }
}