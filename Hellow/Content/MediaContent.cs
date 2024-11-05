using Hellow.Content;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hellow
{
    abstract class MediaContent
    {
        public int Id { get; protected set; }
        public string Title { get; protected set; }
        public string Description { get; private set; }

        private float AverageRating { get; set; } = 0;

        private List<Rating> Ratings { get; } = new List<Rating>();

        public IReadOnlyList<Rating> GetRatings() => Ratings.AsReadOnly();

        private List<Actor> Actors { get; } = new List<Actor>();
        private List<Director> Directors { get; } = new List<Director>();

        public IReadOnlyList<Actor> GetActors() => Actors.AsReadOnly();
        public IReadOnlyList<Director> GetDirectors() => Directors.AsReadOnly();

        public void CalculateAndUpdateRating()
        {
            if (Ratings.Count == 0)
            {
                AverageRating = 0;
            }
            else
            {
                float total = Ratings.Sum(i => i.RatingValue);
                AverageRating = total / Ratings.Count;
            }
        }

        
        public void CreateAndAddNewRating(float ratingValue, User userRater)
        {
            Ratings.Add(new Rating(ratingValue, userRater, this));
            CalculateAndUpdateRating(); 
        }
        public void AddNewRating(Rating rating)
        {
            Ratings.Add(rating);
            CalculateAndUpdateRating(); 
        }

        public void AddNewActor(Actor actor) => Actors.Add(actor);

        public void AddNewDirector(Director director) => Directors.Add(director);

        public float GetAverageRating() => AverageRating;
    }
}
