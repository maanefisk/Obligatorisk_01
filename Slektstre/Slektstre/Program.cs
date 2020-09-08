﻿using System;

namespace Slektstre
{
    class Program
    {
        static void Main(string[] args)
        {
            var sverreMagnus = new Person(1, "Sverre Magnus", null, 2005, null);
            var ingridAlexandra = new Person(2,"Ingrid Alexandra",null, 2004);
            var haakon = new Person(3, "Haakon Magnus",null,1973);
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };
            var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            var sonja = new Person { Id = 7, FirstName = "Sonja", BirthYear = 1937 };
            var olav = new Person { Id = 8, FirstName = "Olav", BirthYear = 1903 };

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            var app = new FamilyApp(sverreMagnus, ingridAlexandra, haakon,
                metteMarit, marius, harald, sonja, olav);
            Console.WriteLine(app.WelcomeMessage);
            while (true)
            {
                Console.Write(app.CommandPrompt);
                var command = Console.ReadLine();
                var response = app.HandleCommand(command);
                Console.WriteLine(response);
            }
        }
}
