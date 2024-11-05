using System;
using System.Threading.Tasks;
using System.Configuration;

namespace Hellow
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Imdb imdb = new Imdb();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var db = new DataBaseLoader(connectionString, imdb);
            await db.LoadDataFromDBToObjects();

            imdb.PrintAll();




           

            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
