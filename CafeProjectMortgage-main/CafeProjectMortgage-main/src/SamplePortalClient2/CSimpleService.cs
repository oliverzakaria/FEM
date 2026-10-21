// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CSimpleService
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CSimpleService
  {
    internal int serviceId;
    internal string serviceName;
    internal ServiceType serviceType;

    public int ServiceId => this.serviceId;

    public string ServiceName => this.serviceName;

    public ServiceType ServiceType => this.serviceType;

    internal CSimpleService()
    {
    }

    internal CSimpleService(int serviceId, string serviceName, ServiceType serviceType)
    {
      this.serviceId = serviceId;
      this.serviceName = serviceName;
      this.serviceType = serviceType;
    }
  }
}
