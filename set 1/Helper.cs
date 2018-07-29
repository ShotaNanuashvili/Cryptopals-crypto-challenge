using System;
using System.Linq;

namespace set_1
{
    public static class Helper
    {
        public static byte[] HexToByteArray(string hex) {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        public static string ByteArrayToString(byte[] bytes) {
            return System.Text.Encoding.Default.GetString(bytes);
        }
    }
}
