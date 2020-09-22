using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slektstre
{
    public class FamilyApp
    {
        public List<Person> _people; //Lager en liste ut av class Person og kaller den _people.
        public string WelcomeMessage {get; set;}
        public string CommandPrompt {get; set;}
    public FamilyApp(params Person[] people) // Alt som ligger i Person blir til Array som heter _people. Constructor.
        {
            _people = new List<Person>(people); //Her blir denne lista navngitt tror jeg

        WelcomeMessage = "Velkommen til familieappen! \n Skriv: \"Hjelp\" for info! \n";
        CommandPrompt = "Gi kommando: \n";
        }

        public string HandleCommand(string command)
        {
            string convertedCommand = command.ToLower();

            if (convertedCommand == ("vis " + command.Substring(4)))
            {
                int commandId = Convert.ToInt32(command.Substring(4));
                return getPersonDescription(commandId) + "\n" + ChildrenOfPerson(commandId);
            }

            if (convertedCommand == "hjelp")
            {
                return "\n\"Hjelp\" - får opp denne hjelp-teksten\n\"Liste\" - Lister alle medlemmer\n\"Vis \"Id-nummer\"\" - viser person med tilhørende ID\n";
            }
            if (convertedCommand == "liste")
            {
                Console.WriteLine(" ");
                foreach (var human in _people)
                {
                    Console.Write(getPersonDescription(human.Id) + "\n");
                }
                return " ";
            }
            return "Error!";
        }

        public string ChildrenOfPerson(int? Id)
        {
            var result = "  Barn:\n";
            var child = "";
            var iPerson = getPersonID(Id);
            if (iPerson == null)
            {
                return "";

            }
            foreach (var homan in _people)
            {
                var father = homan.Father;
                var mother = homan.Mother;
                if (father == iPerson || mother == iPerson)
                {
                    child += ("    " + homan.FirstName) + " " + "(Id=" + homan.Id + ") " + "Født: " + homan.BirthYear + "\n";
                }
            }

            if (child != "")
            {
                return result + child;
            }

            return null;

        }
        public string getPersonDescription(int? Id)
        {
            var oPerson = getPersonID(Id);
            if (oPerson == null) return "Ingen med denne Id'en \n";
            var whoPerson = oPerson.getDescription();
            return whoPerson;
        }
        public Person getPersonID(int? Id)
        {
            return _people.FirstOrDefault(p => p.Id == Id);
        }

        
    }
}