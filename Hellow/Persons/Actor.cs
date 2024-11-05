using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow
{
    internal class Actor : Person
    {
        public int OscarWins = 0;
        public List<MediaContent> ListOfPastContent = new List<MediaContent>();


        public Actor(string name, int age)
        {
            Id = IdGenerator.GetNextActorId();
            Name = name;
            Age = age;
           
        }

        public void AddContentToActor(MediaContent contentToBeAdded)
        {
            ListOfPastContent.Add(contentToBeAdded);
        }
    }
}
