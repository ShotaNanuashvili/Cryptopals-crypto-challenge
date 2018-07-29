using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace set_1
{
    public class SingleByteXorCypher {
        public static void XorCyper() {
            System.Console.WriteLine("Enter hex encoded string: ");
            var hex = Console.ReadLine();
            System.Console.WriteLine("Possibly the original is: " + Decode(hex));
        }

        private static string Decode(string hex) {
            byte[] bytes = Helper.HexToByteArray(hex);
            var possibles = new List<string>();
            for (byte i = 0; i < 255; i++)
            {
                byte[] temp = new byte[bytes.Length];
                for(int j = 0; j<bytes.Length; j++) {
                    temp[j] = Convert.ToByte(bytes[j] ^ i);
                }
                possibles.Add(Helper.ByteArrayToString(temp));
            }

            // consecutive non-vowels
            int threashold = 5;
            char[] arr = {'a','e','i','o','u','y','A','E','I','O','U','Y'};
            for (int i = 0; i < possibles.Count; i++)
            {
                int count = 0;
                for(int j = 0; j<possibles[i].Length; j++) {
                    if(!arr.Contains((possibles[i][j]))) {
                        count++;
                        if(count == threashold) break;
                        continue;
                    }
                    count = 0;
                    if(j==possibles[i].Length-1) return possibles[i];
                }
            }
            return "";
        }
    }
}