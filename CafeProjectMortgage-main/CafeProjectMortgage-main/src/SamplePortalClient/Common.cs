// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.Common
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: D:\Riski\CAFE_1_0_0_2 - Copy\SamplePortalClient.dll

using System;
using System.IO;

namespace SamplePortalClient
{
  public class Common
  {
    public bool FileCopy(string SourceFolder, string TargetFolder)
    {
      try
      {
        string str = "AgentToolbar.config";
        if (File.Exists(SourceFolder + str))
        {
          File.Copy(SourceFolder + str, TargetFolder + str, true);
          return true;
        }
        return false;
      }
      catch (Exception ex)
      {
        return false;
      }
    }
  }
}
