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
        private int _BirthYear;
        private int _YearOfDeath;
        private string _Father;
        private string _Mother;

        public Person (int Id, string FirstName, string SurName, int BirthYear, int YearOfDeath, string Father, string Mother)
        {
            _Id = Id;
            _FirstName = FirstName;
            _SurName = SurName;
            _BirthYear = BirthYear;
            _YearOfDeath = YearOfDeath;
            _Father = Father;
            _Mother = Mother;
        }
    }
}
