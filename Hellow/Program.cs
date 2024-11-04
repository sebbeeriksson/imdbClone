using System;

namespace Hellow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imdb imdb = new Imdb();
            imdb.InitalzieTestDataToImdb();

            foreach (var series in imdb.listOfAllSeries)
            {
                series.PrintAllEpisodeOfShow();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
