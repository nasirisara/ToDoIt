using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoIt.Models;


namespace ToDoIt.Data
{
    public  class PeopleService
    {
        private static Person[] PersonArray = new Person[0];
        private int id;
        private string firstName;
        private string lastName;






        public int Size(Person[] personArraysize)
        {
            int ArrayLenght = personArraysize.Length;
            return ArrayLenght;
        }
         public Person [] FindAll()
        {
            return PersonArray;
        }
       
        public Person FindById(int personId)
        {
           
            foreach (Person person in PersonArray )
            {
                if (personId==person.Id   )
                {
                    return person ;
                }

            }
           
            return null;

        }
        public int PersonId( int Id)
        {
           
            return PersonSequencer.NextPersonId(Id);
        }

        public  Person[] CreatPerson(Person [] increasedPersonArray,string firstName, string lastName,int Id)
        {
         

        Person nextPerson = new Person(PersonId(Id), firstName, lastName);

            Array.Resize<Person>(ref increasedPersonArray, increasedPersonArray.Length + 1);
          Person nextperson= increasedPersonArray[increasedPersonArray.Length -1];
            return increasedPersonArray;
        }

        public void Clear()
        {
            Array.Clear(PersonArray, 0, PersonArray.Length);
        }

    }
}
