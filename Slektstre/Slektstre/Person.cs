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
            string description = "\n";
            if (FirstName != null) description += (FirstName + " \n");
            if (LastName != null) description += (LastName + " \n");
            if (Id != null) description += ("(Id=" + Id + ") \n");
            if (BirthYear != null) description += ("Født: " + BirthYear + " \n");
            if (YearOfDeath != null) description += ("Død: " + YearOfDeath + " \n");
            if (Father != null) description += ("Far: " + Father + " (Id=" + Father.Id + ") \n");
            if (Mother != null) description += ("Mor: " + Mother + " (Id=" + Mother.Id + ") \n");
            return description;
            //if (Mother == null) Mother = "";
            //if (Father == null) //en if for hver verdi, mother, født blablaba
            //return (FirstName + "(Id=" + Id + ") Født: " + BirthYear + " Far: " + Father + " (Id=" + Father.Id + ")\n");
        }
    }
}
