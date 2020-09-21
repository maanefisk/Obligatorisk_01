using Slektstre;
using NUnit.Framework;

namespace Slektstre_testo
{
    public class Tests
    {
        [Test]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                YearOfDeath = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.getDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.getDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void MyOwnTest1()
        {
            var p = new Person
            {
                FirstName = "Charlotte ",
            };

            var actualDescription = p.getDescription();
            var expectedDescription = "Charlotte";

            Assert.AreNotEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void MyOwnTest2()
        {
            var hest = new Person { Id = 1, FirstName = "Hest", BirthYear = 1755 };
            var zebra = new Person { Id = 2, FirstName = "Zebra", BirthYear = 1312 };
            hest.Father = zebra;

            var app = new FamilyApp(hest, zebra);
            var actualResponse = app.HandleCommand("vis 2");
            var expectedResponse = "Zebra (Id=2) Født: 1312 \n"
                                   + "  Barn:\n"
                                   + "    Hest (Id=1) Født: 1755\n";
            Assert.AreEqual(expectedResponse, actualResponse);
        }

        [Test]
        public void FatherTest()
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            sverreMagnus.Father = haakon;
            ingridAlexandra.Father = haakon;
            haakon.Father = harald;

            var app = new FamilyApp(sverreMagnus, ingridAlexandra, haakon);
            var actualResponse = app.HandleCommand("vis 3");
            var expectedResponse = "Haakon Magnus (Id=3) Født: 1973 Far: Harald (Id=6)\n"
                                   + "  Barn:\n"
                                   + "    Sverre Magnus (Id=1) Født: 2005\n"
                                   + "    Ingrid Alexandra (Id=2) Født: 2004\n";
            Assert.AreEqual(expectedResponse, actualResponse);
        }
        [Test]
        public void MotherTest()
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Mother = metteMarit;

            var app = new FamilyApp(sverreMagnus, ingridAlexandra, metteMarit);
            var actualResponse = app.HandleCommand("vis 4");
            var expectedResponse = "Mette-Marit (Id=4) Født: 1973 \n"
                                   + "  Barn:\n"
                                   + "    Sverre Magnus (Id=1) Født: 2005\n"
                                   + "    Ingrid Alexandra (Id=2) Født: 2004\n";
            Assert.AreEqual(expectedResponse, actualResponse);
        }

        [Test]
        public void ChildrenTest()
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };

            var app = new FamilyApp(sverreMagnus, ingridAlexandra, metteMarit);
            var actualResponse = app.HandleCommand("vis 1");
            var expectedResponse = "Sverre Magnus (Id=1) Født: 2005 \n";
            Assert.AreEqual(expectedResponse, actualResponse);
        }

    }
}