using System;
using System.Linq;

namespace set_1
{
    /*
        Example:
        hex: 49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d
        result: SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t
     */
    class HexToBase64
    {
        public static void ConvertHexToBase64() {
            System.Console.WriteLine("Enter Hex: ");
            var hex = Console.ReadLine();
            var base64 = DoConvert(hex);
            System.Console.WriteLine("To Base64: \n" + base64);
        }

        public static string DoConvert(string hex) {
            return Convert.ToBase64String(Helper.HexToByteArray(hex));
        }
    }
}
