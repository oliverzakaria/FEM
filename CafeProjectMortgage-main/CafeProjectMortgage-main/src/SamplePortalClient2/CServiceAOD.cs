// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CServiceAOD
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CServiceAOD : CService
  {
    internal bool allowPreviewNumberChange;
    internal bool timedPreview;
    internal int timedPreviewSecs;

    public bool AllowPreviewNumberChange => this.allowPreviewNumberChange;

    public bool TimedPreview => this.timedPreview;

    public int TimedPreviewSecs => this.timedPreviewSecs;

    internal CServiceAOD()
    {
    }
  }
}
