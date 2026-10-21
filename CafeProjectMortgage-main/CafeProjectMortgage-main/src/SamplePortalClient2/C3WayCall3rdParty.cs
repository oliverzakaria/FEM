// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.C3WayCall3rdParty
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class C3WayCall3rdParty : C3WayCall
  {
    internal object consultationEntity = (object) null;
    internal string consultationPhoneNumber = "";
    internal AgentMediaType mediaType = AgentMediaType.amNONE;

    public object ConsultationEntity => this.consultationEntity;

    public string ConsultationPhoneNumber => this.consultationPhoneNumber;

    public AgentMediaType MediaType => this.mediaType;

    internal C3WayCall3rdParty()
    {
    }
  }
}
