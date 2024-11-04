using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow.Content
{
    internal class Rating
    {
        public int Id;
        public float RatingValue;
        public User UserRater;
        public MediaContent ContentRated;

        public Rating(float ratingValue, User userRater, MediaContent contentRated)
        {
            Id = IdGenerator.GetNextRatingId();
            this.RatingValue = ratingValue;
            this.UserRater = userRater;
            this.ContentRated = contentRated;
        }
    }
}
