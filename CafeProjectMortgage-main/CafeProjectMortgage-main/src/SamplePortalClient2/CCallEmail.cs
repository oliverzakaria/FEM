// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallEmail
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  public class CCallEmail : CCall
  {
    internal string forwardToMBox;
    internal int mailQueId;
    internal int messageId;

    public string ForwardToMBox => this.forwardToMBox;

    public int MailQueId => this.mailQueId;

    public int MessageId => this.messageId;

    internal CCallEmail(UDScreenPop pCall)
      : base(pCall)
    {
      this.forwardToMBox = pCall.callInfo.emailData.forwardToMBox;
      this.mailQueId = pCall.callInfo.emailData.mailQueId;
      this.messageId = pCall.callInfo.emailData.messageId;
    }
  }
}
