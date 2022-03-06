using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Models;
using ToDoIt.Data;


namespace ToDoIt.Tests.Data
{
    public class PeopleServiceTests
    {
        [Fact]
        public void SizeTest()
        {
            Person[] PersonArray = new Person[3];

            PeopleService result = new PeopleService();

            Assert.Equal(3, result.Size(PersonArray));
        }



        [Fact]
        public void FindByIdTrueTest()
        {
            int id = 3;
            string firstName = "SARA";
            string lastName = "Nasiri";


            Person person = new Person(id, firstName, lastName);
            PeopleService people = new PeopleService();
            Person  result = people .FindById (id );

            Assert.Equal(person, result );
        }



        [Fact]
        public void CreatPersonTest()
        {
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            int Id = 6;
            Person[] PersonArray = new Person[3];

            PeopleService peopleService = new PeopleService();


            int ActualLenghtofArrayResult = peopleService .CreatPerson(PersonArray, firstName, lastName, Id).Length;
            Assert.Equal(PersonArray.Length + 1, ActualLenghtofArrayResult);

        }


        [Fact]

        public void ClearTest()
        {
            Person[] PersonArray = new Person[3];
            PeopleService peopleService = new PeopleService();
           
            peopleService.Clear();
            foreach (Person person in PersonArray)
            {
                Assert.Null (person);
            }
            


        }

    }
}
