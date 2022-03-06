using System;
using System.Linq;
using ToDoIt.Data;
using ToDoIt.Models;

namespace ToDoIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] PersonArray = new Person[3];
            string firstName="Sara";
            string lastName="Nasiri";
            int Id=2;

            Person person = new Person(Id, firstName, lastName);

            Person result = FindById(Id, PersonArray);
            Console.WriteLine(result.Id );
        }

        static  Person FindById(int personId, Person [] personArray)
        {

            foreach (Person person in personArray)
            {

                if (personId == person.Id)
                {
                    return person;
                }

            }

            return null;

        }
    }
}
