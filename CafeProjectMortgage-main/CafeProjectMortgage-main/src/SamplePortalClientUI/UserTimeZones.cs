using SamplePortalClient;
using ServiceStack.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SamplePortalClientUI
{
    internal class UserTimeZones
    {

        private CApp mpApp;

        public UserTimeZones(CApp pApp)
        {
            mpApp = pApp;
        }

        internal void Load()
        {
            SamplePortalClient.EPAgentWSP.TimeZone[] timeZones = mpApp.getTimeZones();
            for (int i = 0; i < timeZones.Length; i++)
            {
                UserTimeZone userTimeZone = new UserTimeZone(timeZones[i].id.Value, timeZones[i].gmtoffset.Value, timeZones[i].timezonedesc, timeZones[i].identifier);
                //Log.DebugFormat("[{0}] TimeZone[{1}]: {2}", MethodBase.GetCurrentMethod().Name, i, userTimeZone.ToString());
                //Add(userTimeZone.TimeZoneID, userTimeZone);
            }

           // Log.DebugFormat("[{0}] EXITED", MethodBase.GetCurrentMethod().Name);
        }

        //public new UserTimeZone GetByKey(object key)
        //{
        //    return (UserTimeZone)base.GetByKey(key);
        //}
    }

    public class UserTimeZone
    {
        public int DSTObserved { get; set; }

        public int EndDay { get; set; }

        public int EndDayofWeek { get; set; }

        public int EndMonth { get; set; }

        public int EndTime { get; set; }

        public int GMTOffset { get; set; }

        public int TimeZoneID { get; set; }

        public int StartDay { get; set; }

        public int StartDayofWeek { get; set; }

        public int StartMonth { get; set; }

        public int StartTime { get; set; }

        public int SystemDefault { get; set; }

        public string TimeZoneDesc { get; set; }

        public string Identifier { get; set; }

        public string NanpTimeZoneID { get; set; }

        public UserTimeZone(int xTimeZoneID, int xGMTOffset, string xTimeZoneDesc, string xIdentifier)
        {
            GMTOffset = xGMTOffset;
            TimeZoneID = xTimeZoneID;
            TimeZoneDesc = xTimeZoneDesc;
            Identifier = xIdentifier;
        }

        public UserTimeZone(int xDSTObserved, int xEndDay, int xEndDayofWeek, int xEndMonth, int xEndTime, int xGMTOffset, int xTimeZoneID, int xStartDay, int xStartDayofWeek, int xStartMonth, int xStartTime, int xSystemDefault, string xTimeZoneDesc, string xIdentifier, string xNanpTimeZoneID)
        {
            DSTObserved = xDSTObserved;
            EndDay = xEndDay;
            EndDayofWeek = xEndDayofWeek;
            EndMonth = xEndMonth;
            EndTime = xEndTime;
            GMTOffset = xGMTOffset;
            TimeZoneID = xTimeZoneID;
            StartDay = xStartDay;
            StartDayofWeek = xStartDayofWeek;
            StartMonth = xStartMonth;
            StartTime = xStartTime;
            SystemDefault = xSystemDefault;
            TimeZoneDesc = xTimeZoneDesc;
            Identifier = xIdentifier;
            NanpTimeZoneID = xNanpTimeZoneID;
        }
    }
}
