using System;
using System.Collections.Generic;

namespace CsharpFundamentals
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public List<string> Hobbies { get; set; }

        public Person(string name, DateTime birthday, List<string> hobbies)
        {
            this.Name = name;
            this.BirthDay = birthday;
            this.Hobbies = hobbies;
        }

        public void AddHobby(string hobby)
        {
            Hobbies.Add(hobby);
        }

    }
}
