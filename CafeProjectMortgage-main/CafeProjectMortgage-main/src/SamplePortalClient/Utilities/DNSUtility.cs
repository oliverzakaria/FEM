// Decompiled with JetBrains decompiler
// Type: Utilities.DNSUtility
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: D:\Riski\CAFE_1_0_0_2 - Copy\SamplePortalClient.dll

using SamplePortalClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Utilities
{
  public class DNSUtility
  {

    public static string GetLocalIP()
    {
      try
      {
        return ((IEnumerable<IPAddress>) Dns.GetHostAddresses(Dns.GetHostName())).Where<IPAddress>((Func<IPAddress, bool>) (address => address.AddressFamily == AddressFamily.InterNetwork)).First<IPAddress>().ToString();
      }
      catch (Exception ex)
      {
        throw new Exception("Failed to get Local IP  - ", ex);
      }
    }

    public static string GetDomainName(string sIPAddress)
    {
      return Dns.GetHostEntry(IPAddress.Parse(sIPAddress)).HostName;
    }
  }
}
