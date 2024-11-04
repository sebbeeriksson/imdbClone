using Hellow.Content;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    abstract class MediaContent
    {
        public int Id;
        public string Title;
        public string Description;
        private float AverageRating;
        public List<Rating> Ratings = new List<Rating>();

        private int NumberOfRatings 
        {
            
            get { return NumberOfRatings; }
            set { NumberOfRatings = value; }
        }
       
        

        public void CalculateAndUpdateRating() 
        {
            if (Ratings.Count == 0) { AverageRating = 0; }
            else
            {
                float total = Ratings.Sum(i => i.RatingValue);
                AverageRating = total/Ratings.Count;
            }
           
        }
        public void AddNewRating(float ratingValue, User userRater, MediaContent contentRated)
        {
            Ratings.Add(new Rating(ratingValue, userRater, contentRated));
        }





    }

    
}
