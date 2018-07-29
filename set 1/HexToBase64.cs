using System;
using System.Linq;

namespace set_1
{
    class HexToBase64
    {
        public static void ConvertHexToBase64() {
            System.Console.WriteLine("Enter Hex: ");
            var hex = Console.ReadLine();
            var base64 = DoConvert(hex);
            System.Console.WriteLine("To Base64: \n" + base64);
        }

        public static string DoConvert(string hex) {
            return Convert.ToBase64String(
                Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray());
        }
    }
}
