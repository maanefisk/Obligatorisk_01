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

        WelcomeMessage = "Velkommen til familieappen! \n Skriv: \"hjelp\" for info! \n";
        CommandPrompt = "Gi kommando: \n";
        }

        public string HandleCommand(string command)
        {
            
            string convertedCommand = command.ToLower();

            if (convertedCommand == ("vis " + command.Substring(4)))
            {
                int commandId = Convert.ToInt32(command.Substring(4));
                return getPersonDescription(commandId);
            }
            if (convertedCommand == "hjelp")
            {
                return "\n\"Hjelp\" - får opp denne hjelp-teksten\n\"List\" - Lister alle medlemmer\n\"Vis \"nummer\"\" - viser person med tilhørende ID\n";
            }
            if (convertedCommand == "list")
            {
                return "Liste";
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