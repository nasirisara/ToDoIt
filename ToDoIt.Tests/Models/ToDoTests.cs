using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Models;


namespace ToDoIt.Tests.Models
{
    public class ToDoTests
    {
        [Fact]
        public void ToDoConstructorTest()
        { 
            int id = 2;
            string discription = "Good";
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            Person assignee = new Person(id, firstName, lastName);
           
            ToDo result = new ToDo(id, discription,assignee );
            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
            Assert.Equal(discription, result.Description);
            Assert.Equal(assignee, result.Assignee);

        }

        [Fact]
        public void GoodDiscriptionTest()
        {
            int id = 1;
            String discription = "GoodDiscriptionWorks";
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            Person assignee = new Person(id, firstName, lastName);

            ToDo result = new ToDo(id, discription,assignee );

            Assert.Equal(discription, result.Description);


        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void BadDiscriptionTest(string badDicription)
        {
            int id = 3;
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            Person assignee = new Person(id, firstName, lastName);
            ToDo todo = new ToDo(id, badDicription,assignee );

            Assert.Throws<ArgumentException>(() => todo.Description = badDicription);


        }

        [Fact]
        public void GoodIdTest()
        {
            int id = 1;
            String discription = "Good";
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            Person assignee = new Person(id, firstName, lastName);

            ToDo result = new ToDo(id, discription,assignee );

            Assert.Equal(id, result.Id);


        }

        [Fact]
        public void GoodAssigneeTest()
        {
            int id = 1;
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            string description = "Good";
            Person GoodAssigneeWorks = new Person(id, firstName, lastName);

            ToDo result = new ToDo(id, description, GoodAssigneeWorks);

            Assert.Equal(GoodAssigneeWorks, result.Assignee);

        }
        [Fact]
        public void GoodDoneTest()
        {
            int id = 1;
            String discription = "Good";
            bool DoneWorks = false;
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            Person assignee = new Person(id, firstName, lastName);


            ToDo result = new ToDo(id, discription,assignee );

            Assert.Equal(DoneWorks, result.Done);


        }







    }
}
