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
        public string TitleOfShow;
        public int YearOfRealease;
        private int NumberOfEpisodes = 0;
        public Episode[] Episodes;

        public Series(string title)
        {
            Id = TotalContentCount;
            Title = title;
            TotalContentCount++;
        }




        public void AddEpisodeToShow(Episode episodeToBeAdded)
        {
            Episodes.Append(episodeToBeAdded);
            NumberOfEpisodes++;
        }
        
    }

   
}
