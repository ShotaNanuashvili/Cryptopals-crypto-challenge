using System;

namespace set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Challenge set 1.");
            Console.WriteLine("1 - Convert hex to base64. ");
            Console.WriteLine("2 - XOR two buffers. ");
            Console.WriteLine("3 - Single byte XOR cypher. ");
            Console.WriteLine("4 - Find XORed string. ");
            Console.WriteLine("5 - Repeating-key XOR. ");
            Console.Write("Enter Specific number for a Challenge: ");
            var answer = Console.ReadLine();
            if (answer == "1")
            {
                HexToBase64.ConvertHexToBase64();
            }
            if (answer == "2")
            {
                FixedXOR.XOR();
            }
            if (answer == "3")
            {
                SingleByteXorCypher.XorCyper();
            }
            if (answer == "4")
            {
                FindXORed.FindFromFile();
            }
            if (answer == "5")
            {
                RepeatingXOR.XOR();
            }
        }
    }
}
