// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CLogoutReason
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CLogoutReason : CListItem
  {
    public const int PANIC_LOGOUT_ID = -99;

    internal CLogoutReason(int id, string description)
      : base(id, description)
    {
    }
  }
}
