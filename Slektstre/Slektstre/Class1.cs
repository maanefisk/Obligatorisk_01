using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Slektstre
{
    class Person
    {
        private int _Id;
        private string _FirstName;
        private string _SurName;
        private string _BirthYear;
        private string _YearOfDeath;

        public Person (int Id, string FirstName, string SurName, string BirthYear, string YearOfDeath)
        {
            _Id = Id;
            _FirstName = FirstName;
            _SurName = SurName;
            _BirthYear = BirthYear;
            _YearOfDeath = YearOfDeath;
        }
    }
}
