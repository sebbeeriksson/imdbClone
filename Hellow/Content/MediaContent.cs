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
        private float AverageRating = 0;
        public List<Rating> Ratings = new List<Rating>();
        public List<Actor> Actors = new List<Actor>();
        public List<Director> Directors = new List<Director>();


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
        public void AddNewActor(Actor actor) {  Actors.Add(actor); }
        public void AddNewDirector(Director director) {  Directors.Add(director); }





    }

    
}
