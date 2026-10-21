// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.Common
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.IO;

namespace SamplePortalClient
{
  public class Common
  {
    private LogFile logfile = new LogFile();

    public bool FileCopy(string SourceFolder, string TargetFolder)
    {
      try
      {
        string str = "AgentToolbar.config";
        if (File.Exists(SourceFolder + str))
        {
          this.logfile.LogMessageToFile(" |INFO| Commn.FileCopy() - Config File " + SourceFolder + " found.");
          this.logfile.LogMessageToFile(" |INFO| Commn.FileCopy() - Config File transfer started from " + SourceFolder + " to " + TargetFolder);
          File.Copy(SourceFolder + str, TargetFolder + str, true);
          this.logfile.LogMessageToFile(" |INFO| Commn.FileCopy() - Config File transfer Completed. ");
          return true;
        }
        this.logfile.LogMessageToFile(" |WARNING| Commn.FileCopy() - Config File " + SourceFolder + " not found.");
        return false;
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| Commn.FileCopy() - Config File transfer failed. " + ex.StackTrace.ToString());
        return false;
      }
    }
  }
}
