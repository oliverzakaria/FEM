// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDCallInfoUserDefined
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SamplePortalClient.EPEventsWS
{
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [SoapType(Namespace = "http://Notify.EventService.UD.concerto.com")]
  [Serializable]
  public class UDCallInfoUserDefined
  {
    private UDCallInfoUserDefinedItem uDCallInfoUserDefinedItemField;
    private UDCallInfoUserDefinedItem[] userDefinedItemsField;

    [SoapElement(IsNullable = true)]
    public UDCallInfoUserDefinedItem UDCallInfoUserDefinedItem
    {
      get => this.uDCallInfoUserDefinedItemField;
      set => this.uDCallInfoUserDefinedItemField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallInfoUserDefinedItem[] userDefinedItems
    {
      get => this.userDefinedItemsField;
      set => this.userDefinedItemsField = value;
    }
  }
}
