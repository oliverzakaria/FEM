// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CErrorArgs
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;

namespace SamplePortalClient
{
  public class CErrorArgs : EventArgs
  {
    private ErrorId meCode;
    private int miCallId;
    private string msDescription;
    private LogFile logFile = new LogFile();

    public CErrorArgs(ErrorId eCode, string sDescription, int iCallId)
    {
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CErrorArgs() -  Error Id< " + eCode.ToString() + ">, Description <" + sDescription + "> Call ID<" + iCallId.ToString() + ">Type<" + this.GetType().ToString() + " >", 3);
      this.meCode = eCode;
      this.miCallId = iCallId;
      this.msDescription = sDescription;
    }

    public ErrorId Code => this.meCode;

    public int CallId => this.miCallId;

    public string Description => this.msDescription;
  }
}
