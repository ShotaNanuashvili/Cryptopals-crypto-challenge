using System;

namespace set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Challenge set 1");
            Console.WriteLine("1 - Convert hex to base64");
            Console.WriteLine("2 - Fixed XOR");
            Console.WriteLine("3 - Single-byte XOR cipher");
            Console.WriteLine("4 - Detect single-character XOR");
            Console.WriteLine("5 - Implement repeating-key XOR");
            Console.WriteLine("6 - Break repeating-key XOR");
            Console.WriteLine("7 - AES in ECB mode");
            Console.WriteLine("8 - Detect AES in ECB mode");
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
                default : 
                    Console.ReadKey();
                    break;
            }
        }
    }
}
