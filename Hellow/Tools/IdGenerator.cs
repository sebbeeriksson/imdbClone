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
        public static int EpisodeCount { get; private set; } = 0;
        public static int RatingCount { get; private set; } = 0;
        public static int SeriesCount { get; private set; } = 0;

        public static int GetNextMovieId()
        {
            if (MovieCount == 0) return 0;
            else
            return ++MovieCount; 
        }

        public static int GetNextUserId()
        {
            if (UserCount == 0) { return 0; } else
            return ++UserCount; 
        }

        public static int GetNextActorId()    
        {
            if (ActorCount == 0) { return 0; } else 
            return ++ActorCount; 
        }
        public static int GetNextEpisodeId()
        {
            if (EpisodeCount == 0) { return 0; } else
            return ++ActorCount;
        }
        public static int GetNextRatingId()
        {
            if (RatingCount == 0) { return 0; } else
            return ++ActorCount;
        }
        public static int GetNextSeriesId()
        {
            if (SeriesCount == 0) { return 0; } else
            return ++ActorCount;
        }
    }
}
