// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallRemainingConsultation
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CCallRemainingConsultation : CCallVoice
  {
    internal C3WayCall3rdParty root3rdPartyCall;

    public C3WayCall3rdParty Root3rdPartyCall => this.root3rdPartyCall;

    internal CCallRemainingConsultation(C3WayCall3rdParty root3rdPartyCall)
    {
      this.root3rdPartyCall = root3rdPartyCall;
      this.callID = root3rdPartyCall.CallID;
      this.mediaType = root3rdPartyCall.MediaType == AgentMediaType.amINTERNAL_CONSULT ? AgentMediaType.amINTERNAL_MANUAL : AgentMediaType.amOUTBOUND_MANUAL;
      this.callType = AgentCallType.acMANUAL;
      this.serviceID = root3rdPartyCall.ParentCall.ServiceID;
      this.phoneNumber = root3rdPartyCall.ParentCall.PhoneNumber;
      this.firstName = root3rdPartyCall.ParentCall.FirstName;
      this.lastName = root3rdPartyCall.ParentCall.LastName;
    }
  }
}
