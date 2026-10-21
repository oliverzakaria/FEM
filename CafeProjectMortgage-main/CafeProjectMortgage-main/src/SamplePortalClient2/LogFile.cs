// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.LogFile
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using log4net;
using log4net.Config;
using System;
using System.Data;
using System.Reflection;

namespace SamplePortalClient
{
  public class LogFile
  {
    private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    public void InitializeLog() => XmlConfigurator.Configure();

    public void WriteLine(string message, int LogLevel = 1)
    {
      try
      {
        if (LogLevel > SmartConfiguration.Loglevel)
          return;
        string message1 = " [ " + LogLevel.ToString() + " ] " + message.ToString();
        LogFile.logger.Info((object) message1);
      }
      finally
      {
      }
    }

    public void LogMessageToFile(string message, int LogLevel = 0)
    {
      try
      {
        if (LogLevel > SmartConfiguration.Loglevel)
          return;
        string message1 = " [ " + LogLevel.ToString() + " ] " + message.ToString();
        LogFile.logger.Info((object) message1);
      }
      finally
      {
      }
    }

    public void LogMessageToFile(string message, Exception ExObj)
    {
      string str = message + ExObj.Message.ToString() + "-" + ExObj.Source.ToString();
      try
      {
        string message1 = str.ToString();
        LogFile.logger.Info((object) message1);
      }
      finally
      {
      }
    }

    public void LogMessageToFile(string message, DataException ExObj)
    {
      string str = message + ExObj.Message.ToString() + "-" + ExObj.Source.ToString();
      try
      {
        string message1 = str.ToString();
        LogFile.logger.Info((object) message1);
      }
      finally
      {
      }
    }
  }
}
