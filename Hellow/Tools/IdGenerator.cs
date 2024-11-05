using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    static internal class IdGenerator
    {
        public static int MovieCount { get; private set; } = 0;
        public static int UserCount { get; private set; } = 0;
        public static int ActorCount { get; private set; } = 0;

        public static int DirectorCount { get; private set; } = 0;

        public static int EpisodeCount { get; private set; } = 0;
        public static int RatingCount { get; private set; } = 0;
        public static int SeriesCount { get; private set; } = 0;

        public static int GetNextMovieId()
        {
            
            return ++MovieCount; 
        }

        public static int GetNextUserId()
        {
            
            return ++UserCount; 
        }

        public static int GetNextActorId()    
        {
            
            return ++ActorCount; 
        }

        public static int GetNextDirectorId()
        {

            return ++DirectorCount;
        }
        public static int GetNextEpisodeId()
        {
            
            return ++EpisodeCount;
        }
        public static int GetNextRatingId()
        {
            
            return ++RatingCount;
        }
        public static int GetNextSeriesId()
        {
            
            return ++SeriesCount;
        }
    }
}
