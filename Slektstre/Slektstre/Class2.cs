using System;
using System.Collections.Generic;
using System.Text;

namespace Slektstre
{
    class FamilyApp
    {
        public List<Person> _people;
        public FamilyApp(params Person[] people) // Alt som ligger i Person blir til Array som heter people.
        {
            _people = new List<Person>(people);
        }

        public string WelcomeMessage = "Welcomewelcome";
        public string CommandPrompt = "CommandPrompt";

        public string HandleCommand(string command)
        {
            
            if (command == "vis " + getPersonID())
            {
                Console.WriteLine(Person[getPersonID()]);
            }
        }

        public string getPersonID()
        {
            foreach (var human in _people)
            {
                return Convert.ToString(human.Id);
            }

        }

        
    }
}
