// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CDisposition
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CDisposition : CListItem
  {
    internal string code;
    internal bool isSale;
    internal bool isCallback;
    internal bool isExclusion;

    public string Code => this.code;

    public bool IsSale => this.isSale;

    public bool IsCallback => this.isCallback;

    public bool IsExclusion => this.isExclusion;

    internal CDisposition(
      int id,
      string description,
      string code,
      bool isSale,
      bool isCallback,
      bool isExclusion)
      : base(id, description)
    {
      this.code = code;
      this.isSale = isSale;
      this.isExclusion = isExclusion;
      this.isCallback = isCallback;
    }

    public override string ToString() => this.Description;
  }
}
