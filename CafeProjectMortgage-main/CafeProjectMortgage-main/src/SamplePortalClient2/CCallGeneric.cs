// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallGeneric
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CCallGeneric
  {
    private int _callID;
    internal CState currentState;

    public int CallID => this.callID;

    public CState CurrentState => this.currentState;

    internal virtual int callID
    {
      get => this._callID;
      set => this._callID = value;
    }

    internal CCallGeneric()
    {
    }
  }
}
