using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt_Assignment.Models;


namespace ToDoIt_Assignment.Tests.Models
{
    public class PersonTests
    {


        [Fact]
        public void PersonConstructorTest()
        {
            int id = 666;
            string firstName = "Ola";
            string lastName = "Svensson";

            Person person = new Person(id, firstName, lastName);


            Assert.NotNull(person);
            Assert.Equal(id, person.Id);
            Assert.Equal(firstName, person.Firstname);
            Assert.Equal(lastName, person.Lastname);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]

        public void IsNullOrEmptyTest(string emptyFirstName)
        {

            int Id = 3;
            string lastName = "svensson";
            Person person = new Person(Id, "safeFirstName", lastName);


            Assert.Throws<ArgumentException>(() => person.Firstname = emptyFirstName);


        }
    }
}
