using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    internal class Movie: MediaContent
    {
        public int LengthOfMovie;

      
        public Movie(string title, int lengthOfMovieMinutes)
        {
            Id = TotalContentCount;
            Title = title;
            LengthOfMovie = lengthOfMovieMinutes;
            TotalContentCount++;
        }
    }
}
