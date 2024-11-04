﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    internal class Actor : Person
    {
        public int OscarWins = 0;
        public Movie[] ListOfPastMovies;


        public Actor(int id, string name, int age, DateTime birthday)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthday = birthday;
        }
    }
}
