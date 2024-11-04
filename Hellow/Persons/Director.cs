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
        public int OscarWins;
        public Movie[] listOfDirectedMovies;

        public Director(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
           
        }

    }

   
     
}
