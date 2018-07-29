using System;
using System.Linq;

namespace set_1
{
    class FixedXOR
    {
        public static string XOR(string buffer1, string buffer2) {
            byte[] bytes1 = Enumerable.Range(0, buffer1.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(buffer1.Substring(x, 2), 16))
                .ToArray();
            byte[] bytes2 = Enumerable.Range(0, buffer2.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(buffer2.Substring(x, 2), 16))
                .ToArray();
            for(int i = 0; i<bytes1.Length; i++) {
                bytes1[i] ^= bytes2[i]; 
            }
            var res = BitConverter.ToString(bytes1).Replace("-","");
            return res;
        }

        public static void DoXor() {
            System.Console.WriteLine("Enter first buffer: ");
            string buffer1 = Console.ReadLine();
            System.Console.WriteLine("Enter second buffer: ");
            string buffer2 = Console.ReadLine();
            System.Console.WriteLine("Result: " + XOR(buffer1,buffer2));
        }
    }
}
