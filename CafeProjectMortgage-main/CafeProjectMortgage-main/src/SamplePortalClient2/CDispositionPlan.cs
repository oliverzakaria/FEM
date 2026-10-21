// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CDispositionPlan
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CDispositionPlan
  {
    internal string description;
    private int id;
    private CDispositions dispositions;

    public int Id => this.id;

    public string Description => this.description;

    public CDispositions Dispositions => this.dispositions;

    internal CDispositionPlan(int id, string description)
    {
      this.id = id;
      this.description = description;
      this.dispositions = new CDispositions();
    }
  }
}
