// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CChatEntityArgs
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;

namespace SamplePortalClient
{
  public class CChatEntityArgs : EventArgs
  {
    private string msEntityName;
    private ChatEntityType meEntityType;
    private int miEntityId;

    public CChatEntityArgs(string sEntityName, ChatEntityType eEntityType, int iEntityId)
    {
      this.msEntityName = sEntityName;
      this.meEntityType = eEntityType;
      this.miEntityId = iEntityId;
    }

    public string EntityName => this.msEntityName;

    public ChatEntityType EntityType => this.meEntityType;

    public int EntityId => this.miEntityId;
  }
}
