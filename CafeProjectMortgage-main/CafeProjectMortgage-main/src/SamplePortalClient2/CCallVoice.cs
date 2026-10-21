// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallVoice
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  public class CCallVoice : CCall
  {
    internal C3WayCall thirdPartyCall = (C3WayCall) new C3WayCall3rdParty();
    internal C3WayCall conferenceCall = (C3WayCall) new C3WayCallConference();

    public C3WayCall ThirdPartyCall => this.thirdPartyCall;

    public C3WayCall ConferenceCall => this.conferenceCall;

    private void Initialize()
    {
      this.thirdPartyCall.parentCall = (CCall) this;
      this.conferenceCall.parentCall = (CCall) this;
    }

    internal CCallVoice() => this.Initialize();

    internal CCallVoice(UDScreenPop pCall)
      : base(pCall)
    {
      this.Initialize();
    }

    internal CCallVoice(UDPreview pCall)
      : base(pCall)
    {
      this.Initialize();
    }
  }
}
