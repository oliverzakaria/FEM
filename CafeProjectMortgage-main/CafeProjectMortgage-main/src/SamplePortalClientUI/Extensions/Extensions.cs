using ServiceStack;
using System;

namespace SamplePortalClientUI.Extensions
{
    public static class Extensions
    {
        public static string DecryptPwd(this string encryptedConnectionString)
        {
            string key = Environment.GetEnvironmentVariable("FEM_AES_KEY") ?? "eOf+3QXWI/icWPEWYcd9xUU1QxTX97FGoE121/fAHG0=";
            string iv = Environment.GetEnvironmentVariable("FEM_AES_IV") ?? "zfJe+5MAxjk9VtjH1XcYtA==";

            string decryptedPwd = AesUtils.Decrypt(encryptedConnectionString, 
                Convert.FromBase64String(key), 
                Convert.FromBase64String(iv));
            
            return decryptedPwd;
        }

        public static string EncryptPwd(this string plainConnectionString)
        {
            string key = Environment.GetEnvironmentVariable("FEM_AES_KEY") ?? "eOf+3QXWI/icWPEWYcd9xUU1QxTX97FGoE121/fAHG0=";
            string iv = Environment.GetEnvironmentVariable("FEM_AES_IV") ?? "zfJe+5MAxjk9VtjH1XcYtA==";

            string encryptedPwd = AesUtils.Encrypt(plainConnectionString,
                Convert.FromBase64String(key),
                Convert.FromBase64String(iv));

            return encryptedPwd;
        }
    }
}