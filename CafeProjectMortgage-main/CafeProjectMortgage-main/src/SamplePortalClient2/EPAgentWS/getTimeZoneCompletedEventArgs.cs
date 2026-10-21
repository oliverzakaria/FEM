// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.getTimeZoneCompletedEventArgs
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace SamplePortalClient.EPAgentWS
{
  [GeneratedCode("System.Web.Services", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class getTimeZoneCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal getTimeZoneCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public TimeZone[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (TimeZone[]) this.results[0];
      }
    }
  }
}
