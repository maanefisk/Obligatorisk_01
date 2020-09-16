using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Slektstre
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int YearOfDeath;
        public Person Father;
        public Person Mother;

        public void getDescription()
        {
            Console.WriteLine(FirstName + "(Id=" + Id + ") Født: " + BirthYear + " Far: " + Father + " (Id=" + Father.Id + ")\n");
        }
    }
}
