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
            switch (answer)
            {
                case "1":
                    HexToBase64.ConvertHexToBase64();
                    break;
                case "2":
                    FixedXOR.XOR();
                    break;
                case "3":
                    SingleByteXorCypher.XorCyper();
                    break;
                case "4":
                    FindXORed.FindFromFile();
                    break;
                case "5":
                    RepeatingXOR.XOR();
                    break;
            }
        }
    }
}
