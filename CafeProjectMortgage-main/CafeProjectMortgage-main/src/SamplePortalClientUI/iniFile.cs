// Decompiled with JetBrains decompiler
// Type: CBAS.IniFile.IniReader
// Assembly: CBAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D240DB76-36E8-4412-AADD-328EA348F1CC
// Assembly location: F:\source\SLIK New\Robotik 27112021\CBAS\CBAS.exe

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace SamplePortalClient.UI
{
  public class IniReader
  {
    private string m_Filename;
    private string m_Section;
    private const int MAX_ENTRY = 32768;

    [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileIntA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetPrivateProfileInt(
      string lpApplicationName,
      string lpKeyName,
      int nDefault,
      string lpFileName);

    [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int WritePrivateProfileString(
      string lpApplicationName,
      string lpKeyName,
      string lpString,
      string lpFileName);

    [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetPrivateProfileString(
      string lpApplicationName,
      string lpKeyName,
      string lpDefault,
      StringBuilder lpReturnedString,
      int nSize,
      string lpFileName);

    [DllImport("kernel32", EntryPoint = "GetPrivateProfileSectionNamesA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetPrivateProfileSectionNames(
      byte[] lpszReturnBuffer,
      int nSize,
      string lpFileName);

    [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileSectionA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int WritePrivateProfileSection(
      string lpAppName,
      string lpString,
      string lpFileName);

    public IniReader(string file) => this.Filename = file;

    public string Filename
    {
      get => this.m_Filename;
      set => this.m_Filename = value;
    }

    public string Section
    {
      get => this.m_Section;
      set => this.m_Section = value;
    }

    public int ReadInteger(string section, string key, int defVal) => IniReader.GetPrivateProfileInt(section, key, defVal, this.Filename);

    public int ReadInteger(string section, string key) => this.ReadInteger(section, key, 0);

    public int ReadInteger(string key, int defVal) => this.ReadInteger(this.Section, key, defVal);

    public int ReadInteger(string key) => this.ReadInteger(key, 0);

    public string ReadString(string section, string key, string defVal)
    {
      StringBuilder lpReturnedString = new StringBuilder(32768);
      IniReader.GetPrivateProfileString(section, key, defVal, lpReturnedString, 32768, this.Filename);
      return lpReturnedString.ToString();
    }

    public string ReadString(string section, string key) => this.ReadString(section, key, "");

    public string ReadString(string key) => this.ReadString(this.Section, key);

    public long ReadLong(string section, string key, long defVal) => long.Parse(this.ReadString(section, key, defVal.ToString()));

    public long ReadLong(string section, string key) => this.ReadLong(section, key, 0L);

    public long ReadLong(string key, long defVal) => this.ReadLong(this.Section, key, defVal);

    public long ReadLong(string key) => this.ReadLong(key, 0L);

    public byte[] ReadByteArray(string section, string key)
    {
      try
      {
        return Convert.FromBase64String(this.ReadString(section, key));
      }
      catch
      {
      }
      return (byte[]) null;
    }

    public byte[] ReadByteArray(string key) => this.ReadByteArray(this.Section, key);

    public bool ReadBoolean(string section, string key, bool defVal) => bool.Parse(this.ReadString(section, key, defVal.ToString()));

    public bool ReadBoolean(string section, string key) => this.ReadBoolean(section, key, false);

    public bool ReadBoolean(string key, bool defVal) => this.ReadBoolean(this.Section, key, defVal);

    public bool ReadBoolean(string key) => this.ReadBoolean(this.Section, key);

    public bool Write(string section, string key, int value) => (uint) IniReader.WritePrivateProfileString(section, key, value.ToString(), this.Filename) > 0U;

    public bool Write(string key, int value) => (uint) IniReader.WritePrivateProfileString(this.Section, key, value.ToString(), this.Filename) > 0U;

    public bool Write(string section, string key, string value) => (uint) IniReader.WritePrivateProfileString(section, key, value, this.Filename) > 0U;

    public bool Write(string key, string value) => (uint) IniReader.WritePrivateProfileString(this.Section, key, value, this.Filename) > 0U;

    public bool Write(string section, string key, long value) => (uint) IniReader.WritePrivateProfileString(section, key, value.ToString(), this.Filename) > 0U;

    public bool Write(string key, long value) => (uint) IniReader.WritePrivateProfileString(this.Section, key, value.ToString(), this.Filename) > 0U;

    public bool Write(string section, string key, byte[] value) => value == null ? (uint) IniReader.WritePrivateProfileString(section, key, Convert.ToString((string) null), this.Filename) > 0U : (uint) IniReader.WritePrivateProfileString(section, key, Convert.ToBase64String(value), this.Filename) > 0U;

    public bool Write(string key, byte[] value) => value == null ? (uint) IniReader.WritePrivateProfileString(this.Section, key, Convert.ToString((string) null), this.Filename) > 0U : (uint) IniReader.WritePrivateProfileString(this.Section, key, Convert.ToBase64String(value), this.Filename) > 0U;

    public bool Write(string section, string key, byte[] value, int offset, int length) => value == null ? (uint) IniReader.WritePrivateProfileString(section, key, Convert.ToString((string) null), this.Filename) > 0U : (uint) IniReader.WritePrivateProfileString(section, key, Convert.ToBase64String(value, offset, length), this.Filename) > 0U;

    public bool Write(string section, string key, bool value) => (uint) IniReader.WritePrivateProfileString(section, key, value.ToString(), this.Filename) > 0U;

    public bool Write(string key, bool value) => (uint) IniReader.WritePrivateProfileString(this.Section, key, value.ToString(), this.Filename) > 0U;

    public bool DeleteKey(string section, string key) => (uint) IniReader.WritePrivateProfileString(section, key, (string) null, this.Filename) > 0U;

    public bool DeleteKey(string key) => (uint) IniReader.WritePrivateProfileString(this.Section, key, (string) null, this.Filename) > 0U;

    public bool DeleteSection(string section) => (uint) IniReader.WritePrivateProfileSection(section, (string) null, this.Filename) > 0U;

    public ArrayList GetSectionNames()
    {
      try
      {
        byte[] numArray = new byte[32769];
        IniReader.GetPrivateProfileSectionNames(numArray, 32768, this.Filename);
        return new ArrayList((ICollection) Encoding.ASCII.GetString(numArray).Trim(new char[1]).Split(new char[1]));
      }
      catch
      {
      }
      return (ArrayList) null;
    }
  }
}
