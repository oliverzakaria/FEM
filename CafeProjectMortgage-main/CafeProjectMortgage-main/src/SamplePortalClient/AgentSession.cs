// Decompiled with JetBrains decompiler
// Type: AgentSession
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: D:\Riski\CAFE_1_0_0_2 - Copy\SamplePortalClient.dll

using SamplePortalClient;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

public class AgentSession
{
  private Dictionary<string, string> dcAgentLoginInfo = new Dictionary<string, string>();

  private int ReadURL(string szRequestURL, int nTimeoutValue)
  {
    try
    {
      int num1 = 0;
      int num2 = 0;
      string empty1 = string.Empty;
      string empty2 = string.Empty;
      string empty3 = string.Empty;
      string str1 = Regex.Replace(new WebClient().DownloadString(szRequestURL).Replace("<br>", " ").Replace("\r\n", " ").Replace("\t\t", " ").Replace("\t", " ").Replace("\\", " "), "\\s+", " ");
      num1 = str1.Length;
      string str2 = str1;
      string str3;
      if (str2.IndexOf("total") != -1)
      {
        int startIndex = num2 + str2.IndexOf("total");
        int length = num2 + str2.Substring(startIndex).IndexOf("/>");
        str3 = this.RemoveSpecialCharacters(str1.Substring(startIndex, length)).Replace("total", " ");
      }
      else
        str3 = "0";
      return (int) Convert.ToInt16(str3);
    }
    catch (Exception ex)
    {
      return 0;
    }
  }

  public string RemoveSpecialCharacters(string str)
  {
    return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
  }

  public int AgentLoginCount(string Portal)
  {
    try
    {
      string str = "/ConcertoAgentPortal/status.jsp";
      string szRequestURL = "http://" + Portal + str;
      return this.ReadURL(szRequestURL, 120);
    }
    catch (Exception ex)
    {
      return 9;
    }
  }
}
