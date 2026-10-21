// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CAgentEvent
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  internal class CAgentEvent
  {
    private int id;
    private object payload;

    internal int Id => this.id;

    internal object Payload => this.payload;

    internal CAgentEvent(int id, object payload)
    {
      this.id = id;
      this.payload = payload;
    }
  }
}
