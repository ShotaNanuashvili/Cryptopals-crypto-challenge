using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace set_1
{
    public class SingleByteXorCypher
    {
        public static void XorCyper()
        {
            System.Console.WriteLine("Enter hex encoded string: ");
            var hex = Console.ReadLine();
            System.Console.WriteLine("Original string is: " + Decode(hex));
        }

        public static string Decode(string hex)
        {
            byte[] bytes = Helper.HexToByteArray(hex);
            var possibles = new List<string>();
            for (byte i = 0; i < 255; i++)
            {
                byte[] temp = new byte[bytes.Length];
                for (int j = 0; j < bytes.Length; j++)
                {
                    temp[j] = Convert.ToByte(bytes[j] ^ i);
                }
                possibles.Add(Helper.ByteArrayToString(temp));
            }

            // find the legit sentence
            int threashold = 5;
            int longWord = 12;
            char[] arr = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            for (int i = 0; i < possibles.Count; i++)
            {
                bool isNotValid = false;
                var words = possibles[i].Split(' ');
                foreach (var word in words)
                {
                    //very long words
                    if (word.Length > longWord)
                    {
                        isNotValid = true;
                        break;
                    }
                    //
                    if (word.Length <= 1) continue;
                    int count = 0;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (arr.Contains(word[j]))
                        {
                            count = 0;
                            continue;
                        }
                        count++;
                        // 5 or more consecutive consonants
                        if (count >= threashold)
                        {
                            isNotValid = true;
                            break;
                        }
                    }
                    if (isNotValid) break;
                }
                if (!isNotValid) return possibles[i];
            }
            return "";
        }
    }
}