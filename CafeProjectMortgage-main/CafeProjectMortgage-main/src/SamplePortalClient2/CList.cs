// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CList
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.Collections;

namespace SamplePortalClient
{
  public class CList : ICollection, IEnumerable
  {
    private ArrayList pValues;
    private ArrayList pKeys;

    protected CList()
    {
      this.pValues = new ArrayList();
      this.pKeys = new ArrayList();
    }

    public int Count => this.pValues.Count;

    public bool IsSynchronized => false;

    public object SyncRoot => (object) this;

    public void CopyTo(Array array, int index) => this.pValues.CopyTo(array, index);

    public IEnumerator GetEnumerator() => (IEnumerator) new CList.CListEnumerator(this);

    public bool Contains(object key) => key != null ? this.pKeys.Contains(key) : throw new ArgumentNullException(nameof (key), "Null keys are not allowed");

    protected void Add(object key, object value)
    {
      if (key == null)
        throw new ArgumentNullException(nameof (key), "Null keys are not allowed");
      if (this.pKeys.Contains(key))
        throw new ArgumentException("The specified key already exists. Duplicate keys are not allowed.", nameof (key));
      this.pValues.Add(value);
      this.pKeys.Add(key);
    }

    public object this[int index] => this.pValues[index];

    protected object GetByKey(object key)
    {
      if (key == null)
        throw new ArgumentNullException(nameof (key), "Null keys are not allowed");
      return this.pValues[this.pKeys.IndexOf(key)];
    }

    protected void SetByKey(object key, object value)
    {
      if (key == null)
        throw new ArgumentNullException(nameof (key), "Null keys are not allowed");
      this.pValues[this.pKeys.IndexOf(key)] = value;
    }

    public int IndexOf(object key) => key != null ? this.pKeys.IndexOf(key) : throw new ArgumentNullException(nameof (key), "Null keys are not allowed");

    protected void RemoveAt(int index)
    {
      this.pValues.RemoveAt(index);
      this.pKeys.RemoveAt(index);
    }

    protected internal void RemoveByKey(object key)
    {
      int index = key != null ? this.pKeys.IndexOf(key) : throw new ArgumentNullException(nameof (key), "Null keys are not allowed");
      if (index == -1)
        return;
      this.pKeys.RemoveAt(index);
      this.pValues.RemoveAt(index);
    }

    protected void Clear()
    {
      this.pKeys.Clear();
      this.pValues.Clear();
    }

    private class CListEnumerator : IEnumerator
    {
      private CList Items;
      private int Cursor;

      public CListEnumerator(CList Items)
      {
        this.Items = Items;
        this.Cursor = -1;
      }

      public void Reset() => this.Cursor = -1;

      public bool MoveNext()
      {
        if (this.Cursor < this.Items.Count)
          ++this.Cursor;
        return this.Cursor != this.Items.Count;
      }

      public object Current
      {
        get
        {
          if (this.Cursor < 0 || this.Cursor == this.Items.Count)
            throw new InvalidOperationException();
          return this.Items[this.Cursor];
        }
      }
    }
  }
}
