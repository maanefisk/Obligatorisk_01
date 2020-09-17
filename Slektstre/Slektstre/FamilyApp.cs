using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slektstre
{
    class FamilyApp
    {
        public List<Person> _people;
        public string WelcomeMessage {get; set;}
        public string CommandPrompt {get; set;}
    public FamilyApp(params Person[] people) // Alt som ligger i Person blir til Array som heter people.
        {
            _people = new List<Person>(people);

        WelcomeMessage = "Welcomewelcome";
        CommandPrompt = "CommandPrompt";
        }

        public string HandleCommand(string command)
        {
            int commandId = Convert.ToInt32(command.Substring(4));
            if (command == ("vis " + commandId))
            {
                return getPersonDescription(commandId);
            }

            return "hei";
        }
        public string getPersonDescription(int? Id)
        {
            var oPerson = getPersonID(Id);
            if (oPerson == null) return "Error";
            var whoPerson = oPerson.getDescription();
            return whoPerson;
        }
        public Person getPersonID(int? Id)
        {
            return _people.FirstOrDefault(p => p.Id == Id);
        }

        
        
    }
}