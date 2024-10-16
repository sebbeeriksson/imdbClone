using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    abstract class MediaContent
    {
        public int Id;
        public int TotalContentCount = 0;
        public string Title;
        public string Description;
        private double Rating;
        private int NumberOfRatings 
        {
            
            get { return NumberOfRatings; }
            set { NumberOfRatings = value; }
        }
       
        

        public void CalculateNewRating(double rating) 
        {
            if (NumberOfRatings == 0) { Rating = rating; }
            else{Rating = (NumberOfRatings * Rating + rating) / NumberOfRatings+1;}
            

            NumberOfRatings++;
        }
        

         
    }

    
}
