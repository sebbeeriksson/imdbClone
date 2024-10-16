using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hellow
{
    internal class Director:Person
    {
        public int oscarWins;
        public Movie[] listOfDirectedMovies;

        Director(int id, string name, int age, DateTime birthday)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthday = birthday;
        }

    }

   
     
}
