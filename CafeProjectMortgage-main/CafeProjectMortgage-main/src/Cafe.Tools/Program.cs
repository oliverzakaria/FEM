using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Tools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Environment.GetEnvironmentVariable("FEM_AES_KEY") ?? "eOf+3QXWI/icWPEWYcd9xUU1QxTX97FGoE121/fAHG0=";
            string iv = Environment.GetEnvironmentVariable("FEM_AES_IV") ?? "zfJe+5MAxjk9VtjH1XcYtA==";

            Console.Write("Enter password 1: ");
            string userPassword1 = ReadPassword();
            Console.Write("Enter password 2: ");
            string userPassword2 = ReadPassword();

            if (userPassword1.Length == 0 || userPassword2.Length == 0)
            {
                Console.WriteLine("Passwords cannot be empty.");
                return;
            }

            Console.WriteLine($"Result: {AesUtils.Encrypt(userPassword1+userPassword2,Convert.FromBase64String(key), Convert.FromBase64String(iv))}");
        }

        private static string ReadPassword()
        {
            StringBuilder password = new StringBuilder();
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(intercept: true); // Intercepts the key press so it's not displayed

                // Handle backspace
                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password.Remove(password.Length - 1, 1);
                    Console.Write("\b \b"); // Erase the last asterisk
                }
                // Handle valid character input (not control keys like Shift, Alt, etc.)
                else if (!char.IsControl(key.KeyChar) && key.Key != ConsoleKey.Enter)
                {
                    password.Append(key.KeyChar);
                    Console.Write("*"); // Display an asterisk
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine(); // Move to the next line after Enter is pressed
            return password.ToString();
        }
    }
}
