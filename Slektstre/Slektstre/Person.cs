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

        public string getDescription()
        {
            string description = "";
            if (FirstName != null) description += (FirstName + " ");
            if (LastName != null) description += (LastName + " ");
            if (Id != 0) description += ("(Id=" + Id + ")");
            if (BirthYear != 0) description += (" " + "Født: " + BirthYear + " ");
            if (YearOfDeath != 0) description += ("Død: " + YearOfDeath + " ");
            if (Father != null) description += ("Far: " + Father.FirstName + " (Id=" + Father.Id + ")");
            if (Mother != null) description += (" " + "Mor: " + Mother.FirstName + " (Id=" + Mother.Id + ")");
            
            return description;
            
            //return (FirstName + "(Id=" + Id + ") Født: " + BirthYear + " Far: " + Father + " (Id=" + Father.Id + ")\n");
        }
    }
}
