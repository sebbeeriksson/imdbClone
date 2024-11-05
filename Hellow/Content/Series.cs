using Hellow.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    internal class Series:MediaContent
    {
        public int YearOfRealease;
        private int NumberOfEpisodes = 0;
        public List<Episode> Episodes = new List<Episode>();

        public Series(string title)
        {
            Id = IdGenerator.GetNextSeriesId();
            Title = title;
            
        }




        public void AddEpisodeToShow(Episode episodeToBeAdded)
        {
            episodeToBeAdded.SeriesID = Id;

            Episodes.Add(episodeToBeAdded);
            
            NumberOfEpisodes++;
        }
        public void PrintAllEpisodeOfShow()
        {
            Console.WriteLine(Title);

            foreach (var episode in Episodes)
                Console.WriteLine(episode.TitleOfEpisode);
            {
            }
        }
        
    }

   
}
