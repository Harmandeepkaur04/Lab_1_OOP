using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_OOP
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{PersonId}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            FavoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            return Age + 10;
        }

        public override string ToString()
        {
            return $"PersonId: {PersonId}\nFirstName: {FirstName}\nLastName: {LastName}\nFavoriteColour: {FavoriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";
        }
    }

    class Relation
    {
        public string RelationshipType { get; set; }

        public void ShowRelationship(Person person1, Person person2)
        {
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationshipType}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person { PersonId = 1, FirstName = "Ian", LastName = "Brooks", FavoriteColour = "Red", Age = 30, IsWorking = true };
            Person person2 = new Person { PersonId = 2, FirstName = "Gina", LastName = "James", FavoriteColour = "Green", Age = 18, IsWorking = false };
            Person person3 = new Person { PersonId = 3, FirstName = "Mike", LastName = "Briscoe", FavoriteColour = "Blue", Age = 45, IsWorking = true };
            Person person4 = new Person { PersonId = 4, FirstName = "Mary", LastName = "Beals", FavoriteColour = "Yellow", Age = 28, IsWorking = true };

            Console.WriteLine($"{person2.PersonId}: {person2.FirstName} {person2.LastName}'s favorite colour is {person2.FavoriteColour}");
            Console.WriteLine($"{person3}");
            Console.WriteLine($"{person1.PersonId}: {person1.FirstName} {person1.LastName}'s favorite colour is: White");
            Console.WriteLine($"Mary {person4.LastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}");

            Relation relation1 = new Relation { RelationshipType = "Sisterhood" };
            Relation relation2 = new Relation { RelationshipType = "Brotherhood" };

            relation1.ShowRelationship(person2, person4);
            relation2.ShowRelationship(person1, person3);

            List<Person> peopleList = new List<Person> { person1, person2, person3, person4 };

            double averageAge = peopleList.Average(p => p.Age);
            Person youngestPerson = peopleList.OrderBy(p => p.Age).First();
            Person oldestPerson = peopleList.OrderBy(p => p.Age).Last();

            Console.WriteLine($"Average age is: {averageAge:F2}");
            Console.WriteLine($"The youngest person is: {youngestPerson.FirstName}");
            Console.WriteLine($"The oldest person is: {oldestPerson.FirstName}");

            foreach (var person in peopleList)
            {
                if (person.FavoriteColour == "Blue")
                {
                    Console.WriteLine($"{person}");
                }
            }
        }
    }
}
