using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace WindowsFormsApp1
{
     internal class hash
    {
        public static string hashpassword(string password)
        {
            var has = SHA256.Create();

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] output_hash = has.ComputeHash(b);

            return Convert.ToBase64String(output_hash);
        }

        
    }
}
