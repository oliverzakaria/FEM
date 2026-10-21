// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.C3WayCallManager
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  internal class C3WayCallManager : CList
  {
    private C3WayCall3rdParty mpPendingConsultationCall;

    internal C3WayCall3rdParty PendingConsultationCall
    {
      get => this.mpPendingConsultationCall;
      set => this.mpPendingConsultationCall = value;
    }

    internal C3WayCallManager()
    {
    }

    internal void Add(int key, C3WayCall value) => this.Add((object) key, (object) value);

    internal void RemoveByKey(int key) => this.RemoveByKey((object) key);

    internal C3WayCall GetByKey(int key) => (C3WayCall) this.GetByKey((object) key);

    internal C3WayCall this[int index] => (C3WayCall) base[index];
  }
}
