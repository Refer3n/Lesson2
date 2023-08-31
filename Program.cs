using System.Data.SqlClient;


namespace L2
{
    internal class Program
    {
        private static string ConString => "Data Source=DESKTOP-VI7HLAA\\SQLEXPRESS;Initial Catalog=BarberShop;Integrated Security=True;Connect Timeout=30;";
        static void Main(string[] args)
        {
            using(var SqlCon = new SqlConnection(ConString))
            {
                SqlCon.Open();
                  

                SqlCon.Close();
            }
        }
    }
}