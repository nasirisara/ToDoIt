using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;
using ToDoIt.Models;


namespace ToDoIt.Tests.Data
{
    public class TodoSequencerTests
    {
      
       


        [Fact]
        public void NextTodoIdTest()
        {
           


            Assert.Equal(1, TodoSequencer.NextTodoId());

        }
        [Fact]
        public void ResetTest()
        {
            TodoSequencer.Reset();
            string discription = "Good";
            string firstName = "Sara";
            string lastName = "Nasiri";
            Person assignee = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            ToDo todo = new ToDo(TodoSequencer.NextTodoId(), discription, assignee);

            Assert.Equal(1, todo.Id );

        }


    }
}
