// Decompiled with JetBrains decompiler
// Type: Utilities.ProcessChecker
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: D:\Riski\CAFE_1_0_0_2 - Copy\SamplePortalClient.dll

using SamplePortalClient;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
  public static class ProcessChecker
  {
    private static string _requiredString;
    private static object frmKey;
    private static object frm3Way;
    private static bool bLine1Busy = false;
    private static bool bLine2Busy = false;
    private static object oLine1;
    private static object oLine2;
    private static object oLine1State;
    private static object oLine2State;

    private static bool EnumWindowsProc(IntPtr hWnd, int lParam)
    {
      int lpdwProcessId = 0;
      ProcessChecker.NativeMethods.GetWindowThreadProcessId(hWnd, ref lpdwProcessId);
      StringBuilder lpString = new StringBuilder(1024);
      ProcessChecker.NativeMethods.GetWindowText(hWnd, lpString, 1024);
      if (lpdwProcessId == lParam && lpString.ToString().IndexOf(ProcessChecker._requiredString, StringComparison.OrdinalIgnoreCase) != -1)
      {
        ProcessChecker.NativeMethods.ShowWindowAsync(hWnd, 1);
        ProcessChecker.NativeMethods.SetForegroundWindow(hWnd);
      }
      return true;
    }

    public static bool IsOnlyProcess(string forceTitle)
    {
      ProcessChecker._requiredString = forceTitle;
      foreach (Process process in Process.GetProcessesByName(Application.ProductName))
      {
        if (process.Id != Process.GetCurrentProcess().Id)
        {
          ProcessChecker.NativeMethods.EnumWindows(new ProcessChecker.EnumWindowsProcDel(ProcessChecker.EnumWindowsProc), process.Id);
          return false;
        }
      }
      return true;
    }

    public static object globalKeyPad
    {
      get => ProcessChecker.frmKey;
      set => ProcessChecker.frmKey = value;
    }

    public static object global3Way
    {
      get => ProcessChecker.frm3Way;
      set => ProcessChecker.frm3Way = value;
    }

    public static bool Line1Busy
    {
      get => ProcessChecker.bLine1Busy;
      set => ProcessChecker.bLine1Busy = value;
    }

    public static bool Line2Busy
    {
      get => ProcessChecker.bLine2Busy;
      set => ProcessChecker.bLine2Busy = value;
    }

    public static object Line1ScreenPop
    {
      get => ProcessChecker.oLine1;
      set => ProcessChecker.oLine1 = value;
    }

    public static object Line2ScreenPop
    {
      get => ProcessChecker.oLine2;
      set => ProcessChecker.oLine2 = value;
    }

    public static object Line1State
    {
      get => ProcessChecker.oLine1State;
      set => ProcessChecker.oLine1State = value;
    }

    public static object Line2State
    {
      get => ProcessChecker.oLine2State;
      set => ProcessChecker.oLine2State = value;
    }

    public static int LastCallClearCallId { get; set; }

    public static int ActiveLine { get; set; }

    public static bool Is3Way { get; set; }

    public static bool CheckAndSetIsLine1(int iCallID)
    {
      bool flag = false;
      if (ProcessChecker.Line1ScreenPop != null && ((CCallGeneric) ProcessChecker.Line1ScreenPop).callID == iCallID)
        flag = true;
      if (!flag)
      {
        if (ProcessChecker.Line1Busy)
          ProcessChecker.ActiveLine = 2;
      }
      else if (ProcessChecker.Line2Busy)
        ProcessChecker.ActiveLine = 1;
      return flag;
    }

    internal static class NativeMethods
    {
      public const int SW_SHOWNORMAL = 1;

      [DllImport("user32.dll")]
      public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

      [DllImport("user32.dll")]
      public static extern bool SetForegroundWindow(IntPtr hWnd);

      [DllImport("user32.dll")]
      public static extern bool EnumWindows(
        ProcessChecker.EnumWindowsProcDel lpEnumFunc,
        int lParam);

      [DllImport("user32.dll")]
      public static extern int GetWindowThreadProcessId(IntPtr hWnd, ref int lpdwProcessId);

      [DllImport("user32.dll")]
      public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
    }

    public delegate bool EnumWindowsProcDel(IntPtr hWnd, int lParam);
  }
}
