// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CPasscodeArgs
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;

namespace SamplePortalClient
{
  public class CPasscodeArgs : EventArgs
  {
    private string msPasscode;
    private bool mbValid;

    public CPasscodeArgs(string sPasscode, bool bValid)
    {
      this.msPasscode = sPasscode;
      this.mbValid = bValid;
    }

    public string Passcode => this.msPasscode;

    public bool Valid => this.mbValid;
  }
}
