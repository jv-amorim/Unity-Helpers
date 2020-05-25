using System.Text;
using System.Security.Cryptography;

namespace UnityHelpers.HashingHelpers
{
    public static class HashGenerator
    {
        public static string GenerateCryptographicHash(string input)
        {
            byte[] data = Encoding.ASCII.GetBytes(input);
            data = new SHA256Managed().ComputeHash(data);
            string hash = Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}