using System;
using System.Globalization;

namespace SamplePortalClientUI.Extensions
{
    public static class StringExtensions
    {
        public static string ToMoneyFormat(this string str, int declen)
        {
            decimal.TryParse(str, out decimal dbl);
            NumberFormatInfo customFormat = new NumberFormatInfo
            {
                NumberDecimalSeparator = ",",
                NumberGroupSeparator = ".", // No thousands separator
                NumberDecimalDigits = declen
            };
            //dbl = dbl / 10000;
            string s = dbl.ToString("N", CultureInfo.InvariantCulture);
            int index = s.IndexOf('.');
            int decimalPlaces = index == -1 ? 0 : s.Length - index - 1;
            return "IDR " + dbl.ToString($"N{decimalPlaces}", customFormat);
        }

    }
}
