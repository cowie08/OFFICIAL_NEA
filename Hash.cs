using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OFFICIAL_NEA
{
    internal class Hash
    {
        public static string PasswordHashCreator(string data)
        {
            using(SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(data));
                StringBuilder sb = new StringBuilder();
                foreach(byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));

                }
                return sb.ToString();
            }
        
        }



    }
}
