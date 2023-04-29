using md5_sql_hash;
using System.Text;

internal static class md5Helpers
{
    public static string HashPassword(string password)
    {
        md5 md5 = new md5();
        byte[] b = Encoding.ASCII.GetBytes(password);
        byte[] hash = md5.ComputeHash(b);

    }
}