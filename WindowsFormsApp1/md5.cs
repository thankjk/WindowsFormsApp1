using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace md5_sql_hash
{
    internal class md5
    {
        public static  string HashPassword(string password)
        {
            md5 md5 = new md5();
            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);

        }

        private byte[] ComputeHash(byte[] b)
        {
            throw new NotImplementedException();
        }
    }
}
