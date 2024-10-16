using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    internal class User : Person
    {
        public void RateContent(MediaContent contentToBeRated, double rating)
        {
            contentToBeRated.CalculateNewRating(rating);
        }
    }
}
