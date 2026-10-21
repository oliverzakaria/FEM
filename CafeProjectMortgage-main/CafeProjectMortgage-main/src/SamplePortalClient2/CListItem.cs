// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CListItem
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CListItem
  {
    private int id;
    internal string description;

    public int Id => this.id;

    public string Description => this.description;

    internal CListItem(int id, string description)
    {
      this.id = id;
      this.description = description;
    }

    public override string ToString() => this.id.ToString() + "\t" + this.description;
  }
}
