// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallActivatedArgs
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;

namespace SamplePortalClient
{
  public class CCallActivatedArgs : EventArgs
  {
    private CCall mpActivatedCall;
    private CCall mpDeactivatedCall;

    public CCallActivatedArgs(CCall pDeactivatedCall, CCall pActivatedCall)
    {
      this.mpActivatedCall = pActivatedCall;
      this.mpDeactivatedCall = pDeactivatedCall;
    }

    public CCall ActivatedCall => this.mpActivatedCall;

    public CCall DeactivatedCall => this.mpDeactivatedCall;
  }
}
