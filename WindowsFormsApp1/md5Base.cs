using System.Text;

namespace md5_sql_hash
{
    internal class md5Base
    {
        public static string HashPassword(string password)
        {
            md5 md5 = new md5();
            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);

        }
    }
}