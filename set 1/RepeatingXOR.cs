using System;
using System.IO;

namespace set_1
{
    /*
        Encripting text from repeating.txt
     */
    public class RepeatingXOR
    {
        public static void XOR()
        {
            var text = File.ReadAllText(@"source-files/repeating.txt");
            System.Console.Write("Enter key: ");
            var key = Console.ReadLine();
            System.Console.WriteLine("Hex: " + DoXOR(text,key));
        }

        private static string DoXOR(string text, string key)
        {
            var bytes = Helper.StringToByteArray(text);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(bytes[i] ^ key[(i%key.Length)]);
            }
            return Helper.ByteArrayToHex(bytes);
        }
    }
}