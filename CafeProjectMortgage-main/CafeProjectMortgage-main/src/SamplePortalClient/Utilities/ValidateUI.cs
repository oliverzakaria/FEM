// Decompiled with JetBrains decompiler
// Type: Utilities.ValidateUI
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: D:\Riski\CAFE_1_0_0_2 - Copy\SamplePortalClient.dll

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Utilities
{
  public class ValidateUI
  {
    private const int WM_SYSCOMMAND = 274;
    private const int SC_CLOSE = 61536;

    [DllImport("user32.dll")]
    private static extern int FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll")]
    private static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

    public static bool IsAlpha(string input) => Regex.IsMatch(input, "^[a-zA-Z]+$");

    public static bool IsNumeric(string input) => Regex.IsMatch(input, "^[0-9]+$");

    public static bool IsAlphaNumeric(string input) => Regex.IsMatch(input, "^[a-zA-Z0-9 ]+$");

    public static bool IsAlphaNumericWithUnderscore(string input)
    {
      return Regex.IsMatch(input, "^[a-zA-Z0-9_]+$");
    }

    public static bool IsDateValid(string stringDateValue)
    {
      try
      {
        CultureInfo provider = new CultureInfo("fr-FR");
        DateTime.ParseExact(stringDateValue, "dd/MM/yyyy", (IFormatProvider) provider);
        return true;
      }
      catch
      {
        return false;
      }
    }

    public static bool IsTimeValid(string time)
    {
      return DateTime.TryParseExact(time, "HH:mm:ss", (IFormatProvider) CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime _);
    }

    public static void CloseWindow(string ClassName, string WindowName)
    {
      int window = ValidateUI.FindWindow(ClassName, WindowName);
      if (window <= 0)
        return;
      ValidateUI.SendMessage(window, 274U, 61536, 0);
    }
  }
}
