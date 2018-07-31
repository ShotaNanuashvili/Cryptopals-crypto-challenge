using System;
using System.Linq;

namespace set_1
{
    /*
        Example: 
        First: 1c0111001f010100061a024b53535009181c
        Second: 686974207468652062756c6c277320657965
        Result: 746865206b696420646f6e277420706c6179
     */
    class FixedXOR
    {
        private static string DoXor(string buffer1, string buffer2) {
            byte[] bytes1 = Helper.HexToByteArray(buffer1);
            byte[] bytes2 = Helper.HexToByteArray(buffer2);
            for(int i = 0; i<bytes1.Length; i++) {
                bytes1[i] ^= bytes2[i]; 
            }
            var res = BitConverter.ToString(bytes1).Replace("-","");
            return res;
        }

        public static void XOR() {
            System.Console.WriteLine("Enter first buffer: ");
            string buffer1 = Console.ReadLine();
            System.Console.WriteLine("Enter second buffer: ");
            string buffer2 = Console.ReadLine();
            System.Console.WriteLine("Result: " + DoXor(buffer1,buffer2));
        }
    }
}
