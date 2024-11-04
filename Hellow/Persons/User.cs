using Hellow.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    internal class User : Person
    {

        public List<Rating> UsersRatings = new List<Rating>();

        public void RateContent(MediaContent contentToBeRated, float rating)
        {
            contentToBeRated.AddNewRating(rating,this,contentToBeRated);
        }
    }
}
