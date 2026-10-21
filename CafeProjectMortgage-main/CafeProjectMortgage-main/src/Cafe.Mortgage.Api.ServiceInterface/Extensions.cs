using ServiceStack;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Mortgage.Api.ServiceInterface
{
    public static class Extensions
    {
        public static string DecryptPwd(this string encryptedConnectionString)
        {
            string key = Environment.GetEnvironmentVariable("FEM_AES_KEY") ?? "eOf+3QXWI/icWPEWYcd9xUU1QxTX97FGoE121/fAHG0=";
            string iv = Environment.GetEnvironmentVariable("FEM_AES_IV") ?? "zfJe+5MAxjk9VtjH1XcYtA==";

            string s = encryptedConnectionString.Substring(
                encryptedConnectionString.IndexOf("pwd=", StringComparison.OrdinalIgnoreCase));
            s = s.Substring(0, s.IndexOf(";"));

            string encryptedPwd = s.Substring(s.IndexOf("=", StringComparison.OrdinalIgnoreCase) + 1);
            string decryptedPwd = AesUtils.Decrypt(encryptedPwd, 
                Convert.FromBase64String(key), 
                Convert.FromBase64String(iv));
            
            return encryptedConnectionString.Replace(encryptedPwd, decryptedPwd);
        }

        public static string EncryptPwd(this string plainConnectionString)
        {
            string key = Environment.GetEnvironmentVariable("FEM_AES_KEY") ?? "eOf+3QXWI/icWPEWYcd9xUU1QxTX97FGoE121/fAHG0=";
            string iv = Environment.GetEnvironmentVariable("FEM_AES_IV") ?? "zfJe+5MAxjk9VtjH1XcYtA==";

            string s = plainConnectionString.Substring(
                plainConnectionString.IndexOf("pwd=", StringComparison.OrdinalIgnoreCase));
            s = s.Substring(0, s.IndexOf(";"));

            string plainPwd = s.Substring(s.IndexOf("=", StringComparison.OrdinalIgnoreCase) + 1);
            string encryptedPwd = AesUtils.Encrypt(plainPwd,
                Convert.FromBase64String(key),
                Convert.FromBase64String(iv));

            return plainConnectionString.Replace(plainPwd, encryptedPwd);
        }
    }
}