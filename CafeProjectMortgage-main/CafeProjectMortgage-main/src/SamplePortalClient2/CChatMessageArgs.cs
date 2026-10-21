// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CChatMessageArgs
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;

namespace SamplePortalClient
{
  public class CChatMessageArgs : EventArgs
  {
    private int miCallId;
    private string msMessage;
    private ChatEntityType meEntityType;
    private string msEntityName;

    public CChatMessageArgs(
      int iCallId,
      ChatEntityType eEntityType,
      string sEntityName,
      string sMessage)
    {
      this.miCallId = iCallId;
      this.msMessage = sMessage;
      this.msEntityName = sEntityName;
      this.meEntityType = eEntityType;
    }

    public string Message => this.msMessage;

    public int CallId => this.miCallId;

    public string EntityName => this.msEntityName;

    public ChatEntityType EntityType => this.meEntityType;
  }
}
