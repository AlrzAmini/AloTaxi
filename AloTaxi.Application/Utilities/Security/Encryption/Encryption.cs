using Effortless.Net.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloTaxi.Application.Utilities.Security.Encryption
{
    public static class Encryption
    {
        public static string Encrypt(string input)
        {
            byte[] key = Bytes.GenerateKey();
            byte[] iv = Bytes.GenerateIV();

            string encrypted = Strings.Encrypt(input, key, iv);

            return encrypted;
        }

        public static string Decrypt(string encrypted)
        {
            byte[] key = Bytes.GenerateKey();
            byte[] iv = Bytes.GenerateIV();

            string decrypted = Strings.Decrypt(encrypted, key, iv);
            
            return decrypted;
        }
    }
}
