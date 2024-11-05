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
        public List<MediaContent> ListOfPastContent = new List<MediaContent>();

        public Director(string name, int age)
        {
            Id = IdGenerator.GetNextDirectorId();

            Name = name;
            Age = age;
           
        }

        public void AddContentToDirector(MediaContent contentToBeAdded)
        {
            ListOfPastContent.Add(contentToBeAdded);
        }

    }

   
     
}
