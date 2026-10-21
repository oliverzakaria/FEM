// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.SmartConfiguration
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: D:\Riski\CAFE_1_0_0_2 - Copy\SamplePortalClient.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using XML_Configuration;

namespace SamplePortalClient
{
  public static class SmartConfiguration
  {
    private static string _Version = string.Empty;
    private static string _Interfacename = string.Empty;
    private static string _Portal = string.Empty;
    private static string _Site = string.Empty;
    private static string _DomainName = string.Empty;
    private static string _DomainProtocol = "https://";
    private static string _MandatoryCDDCallType = string.Empty;
    private static string _MandatoryCDDField = string.Empty;
    private static string _PublishAgentIDForServiceID = string.Empty;
    private static string _DBIntegrationServiceIP = string.Empty;
    private static string _ShowExclusion = string.Empty;
    private static string _ExclusionType = string.Empty;
    private static string _ExclusionDuration = string.Empty;
    private static string _UIPExclusionDuration = string.Empty;
    private static string _ExclusionAppID = string.Empty;
    private static string _CDDParamForExclusionValue = string.Empty;
    private static string _CDDParamforTransferInfo = string.Empty;
    private static List<int> _DispositionIDs = new List<int>();
    private static int _CDDParamForCustomerName;
    private static int _CDDParamForCustomerNRIC;
    private static List<int> _ProductServiceIDs = new List<int>();
    private static string _ConfirmIVRServiceID = string.Empty;
    private static string _EmptyMemoIdentifier = "<m3m0>";
    private static string _CustomCallBackForAOD = string.Empty;
    private static string _ExclusionCharacters = string.Empty;
    private static string _CallbackAlternateNumber = string.Empty;
    private static string _LMSScreenPopURL = string.Empty;
    private static int _CDDParamForUniqueID = 0;
    private static int _CDDParamForOverrideNo = 0;
    private static string _CallBackTime = "00:00-24:00";
    private static string _ALMUserName = "";
    private static string _ALMPassword = "";
    private static string _ALMCallbackWebService = "";
    private static string _AccountNumberFieldNo = "";
    private static string _AuthFlagFieldNo = "";
    private static string _CallingNoFieldNo = "";
    private static string _CRMNEXTURL = "";
    private static string _ServiceAgentMappingURL = "";
    private static string _SurveyServiceID;
    private static List<int> _OverrideDisposeIDs = new List<int>();
    private static List<int> _OverrideServiceIDs = new List<int>();
    public static Sites _ListOfSites = new Sites();
    private static int _StationID;
    private static string _CDDOnTop;
    private static string _CDDKeepVisible;
    private static int _Loglevel;
    private static string sParameters = string.Empty;
    private static string[] sParameterList;
    private static LogFile logFile = new LogFile();
    public static string sConfigFilePath = "https://UATCUSTAPP.ibl.com/CAFE/CAFEConfig.html";

    public static void LoadSmartConfiguration()
    {
      try
      {
        SmartConfiguration.logFile.LogMessageToFile(" |INFO| SmartConfiguration() - Constructor, Reading [ " + SmartConfiguration.sConfigFilePath + " ] configuration file");
        string sHTMLString = new WebClient().DownloadString(SmartConfiguration.sConfigFilePath);
        SmartConfiguration.logFile.LogMessageToFile(" |INFO| SmartConfiguration() - Constructor, Path = [" + sHTMLString + "]");
        SmartConfiguration.logFile.LogMessageToFile(" |INFO| SmartConfiguration() - Constructor, Reading configuration file complete.");
        SmartConfiguration.FilterConfig(sHTMLString);
        SmartConfiguration.logFile.LogMessageToFile(" |INFO| SmartConfiguration() - Constructor, Reading configuration paramters complete.");
      }
      catch (Exception ex)
      {
        SmartConfiguration.logFile.LogMessageToFile(" |ERROR| SmartConfiguration() - Constructor, Reading configuration failed." + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new WebException("Configuration file not found.");
      }
    }

    private static void FilterConfig(string sHTMLString)
    {
      try
      {
        if (sHTMLString.Trim().Length <= 0)
          return;
        SmartConfiguration.sParameters = "Version";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._Version = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1), sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "AccountNumberFieldNo";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._AccountNumberFieldNo = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "AuthFlagFieldNo";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._AuthFlagFieldNo = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "CallingNoFieldNo";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._CallingNoFieldNo = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "CRMNEXTURL";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._CRMNEXTURL = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "ServiceAgentMappingURL";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._ServiceAgentMappingURL = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "SurveyServiceID";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._SurveyServiceID = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "Domain";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._DomainName = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1), sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "ReportingServiceURL";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration.ReportingServiceURL = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "Site";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._Site = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
        SmartConfiguration.sParameters = "Loglevel";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
          SmartConfiguration._Loglevel = (int) Convert.ToInt16(sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1)));
        SmartConfiguration.sParameters = "Sites";
        if (sHTMLString.Trim().IndexOf(SmartConfiguration.sParameters) > 0)
        {
          XmlDocument xmlDocument = new XmlDocument();
          string str1 = sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + SmartConfiguration.sParameters.Length + 1, sHTMLString.Substring(sHTMLString.IndexOf(SmartConfiguration.sParameters) + (SmartConfiguration.sParameters.Length + 1)).IndexOf("/>") - (SmartConfiguration.sParameters.Length + 1));
          string str2;
          string s = str2 = "<Sites>" + str1 + "</Sites>";
          using (TextReader textReader = (TextReader) new StringReader(s))
            SmartConfiguration._ListOfSites = (Sites) new XmlSerializer(typeof (Sites)).Deserialize(textReader);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Log file Read Error, File path : -" + SmartConfiguration.sConfigFilePath, ex);
      }
    }

    public static string ServiceID
    {
      get => SmartConfiguration._SurveyServiceID;
      set => SmartConfiguration._SurveyServiceID = value;
    }

    public static string CRMNEXTURL
    {
      get => SmartConfiguration._CRMNEXTURL;
      set => SmartConfiguration._CRMNEXTURL = value;
    }

    public static string ServiceAgentMappingURL
    {
      get => SmartConfiguration._ServiceAgentMappingURL;
      set => SmartConfiguration._ServiceAgentMappingURL = value;
    }

    public static Sites ListOfSites
    {
      get => SmartConfiguration._ListOfSites;
      set => SmartConfiguration._ListOfSites = value;
    }

    public static string CallingNoFieldNo
    {
      get => SmartConfiguration._CallingNoFieldNo;
      set => SmartConfiguration._CallingNoFieldNo = value;
    }

    public static string AuthFlagFieldNo
    {
      get => SmartConfiguration._AuthFlagFieldNo;
      set => SmartConfiguration._AuthFlagFieldNo = value;
    }

    public static string AccountNumberFieldNo
    {
      get => SmartConfiguration._AccountNumberFieldNo;
      set => SmartConfiguration._AccountNumberFieldNo = value;
    }

    public static string Version
    {
      get => SmartConfiguration._Version;
      set => SmartConfiguration._Version = value;
    }

    public static string ReportingServiceURL { get; set; }

    public static int Loglevel
    {
      get => SmartConfiguration._Loglevel;
      set => SmartConfiguration._Loglevel = value;
    }
  }
}
