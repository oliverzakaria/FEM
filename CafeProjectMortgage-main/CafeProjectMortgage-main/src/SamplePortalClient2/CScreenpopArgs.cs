// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CScreenpopArgs
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;

namespace SamplePortalClient
{
  public class CScreenpopArgs : EventArgs
  {
    private CCall mpCall;

    public CScreenpopArgs(CCall pCall) => this.mpCall = pCall;

    public CCall Call => this.mpCall;
  }
}
