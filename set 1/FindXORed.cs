using System;
using System.Linq;
using System.Text;
using System.IO;

namespace set_1
{
    /*
        Decrypting from strings.txt
     */
    public class FindXORed
    {
        public static void FindFromFile()
        {
            System.Console.WriteLine("That XORed string is in line: " + GetLine());
        }

        private static int GetLine()
        {
            var lines = File.ReadAllLines(@"source-files/strings.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                var decoded = SingleByteXorCypher.Decode(lines[i]);
                if (decoded != "")
                {
                    System.Console.Write("Decoded string is: " + decoded);
                    return i + 1;
                }
            }
            return 0;
        }
    }
}