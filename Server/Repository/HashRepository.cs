using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Repository
{
    public class HashRepository
    {
        private string PasswordHash;
        public string Sha1(string password)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] Result = sh.Hash;
            StringBuilder sB = new StringBuilder();
            foreach (byte b in Result)
            {
                sB.Append(b.ToString("x2"));
            }
            PasswordHash = sB.ToString();
            return PasswordHash;
        }
    }
}
