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
            if (Father == null || Mother == null) //en if for hver verdi, mother, født blablaba
                return (FirstName + "(Id=" + Id + ") Født: " + BirthYear + " Far: " + Father + " (Id=" + Father.Id + ")\n");
        }
    }
}
