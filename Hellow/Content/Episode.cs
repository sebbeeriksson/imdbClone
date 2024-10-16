using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow.Content
{
    internal class Episode
    {
        public int Id { get; set; } public string TitleOfEpisode { get; set; }
        public int Season;
        public int LengthOfEpisode;public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

       
        public Episode(string title, int lenghtOfEpisode, int season) 
        {
            TitleOfEpisode = title;
            LengthOfEpisode = lenghtOfEpisode;
            Season = season;
        }
    }
}
