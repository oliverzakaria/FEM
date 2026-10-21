// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CUser
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CUser
  {
    private string id;
    private string firstName;
    private string lastName;

    public string Id => this.id;

    public string FirstName => this.firstName;

    public string LastName => this.lastName;

    internal CUser(string id, string firstName, string lastName)
    {
      this.id = id;
      this.firstName = firstName;
      this.lastName = lastName;
    }
  }
}
