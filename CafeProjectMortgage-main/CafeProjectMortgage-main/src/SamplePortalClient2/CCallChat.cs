// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallChat
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  public class CCallChat : CCall
  {
    internal string chatServerIP = (string) null;
    internal int chatServerPort = 0;

    public string ChatServerIP => this.chatServerIP;

    public int ChatServerPort => this.chatServerPort;

    internal CCallChat(UDScreenPop pCall)
      : base(pCall)
    {
    }
  }
}
