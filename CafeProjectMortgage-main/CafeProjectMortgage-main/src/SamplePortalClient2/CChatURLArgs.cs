// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CChatURLArgs
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;

namespace SamplePortalClient
{
  public class CChatURLArgs : EventArgs
  {
    private int miCallId;
    private string msURL;
    private ChatEntityType meEntityType;
    private string msEntityName;

    public CChatURLArgs(int iCallId, ChatEntityType eEntityType, string sEntityName, string sURL)
    {
      this.miCallId = iCallId;
      this.msURL = sURL;
      this.msEntityName = sEntityName;
      this.meEntityType = eEntityType;
    }

    public string URL => this.msURL;

    public int CallId => this.miCallId;

    public string EntityName => this.msEntityName;

    public ChatEntityType EntityType => this.meEntityType;
  }
}
