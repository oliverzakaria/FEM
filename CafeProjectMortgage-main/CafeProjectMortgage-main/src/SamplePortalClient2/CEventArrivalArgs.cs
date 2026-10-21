// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CEventArrivalArgs
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using System;

namespace SamplePortalClient
{
  internal class CEventArrivalArgs : EventArgs
  {
    private AgentEvent mpNextEvent;

    public CEventArrivalArgs(AgentEvent pNextEvent) => this.mpNextEvent = pNextEvent;

    public AgentEvent NextEvent => this.mpNextEvent;
  }
}
