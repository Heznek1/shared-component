using System;
using System.Security.Cryptography;
using System.Text;

namespace Shared.Encryption
{
    public static class EncriptPassword
    {
        public static string EncryptPassword(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }

            var inputBytes = Encoding.UTF8.GetBytes(input);
            var hashBytes = new SHA512Managed().ComputeHash(inputBytes);
            var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

            return hash;
        }
    }
}
