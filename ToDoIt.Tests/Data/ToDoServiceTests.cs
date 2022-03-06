using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;
using ToDoIt.Models;

namespace ToDoIt.Tests.Data
{
    public class ToDoServiceTests
    {
        [Fact]
        public void SizeTest()
        {
            ToDo[] TodoArray = new ToDo[3];

            TodoService result = new TodoService ();

            Assert.Equal(3, result.Size(TodoArray));
        }


        [Fact]
        public void FindByIdTrueTest()
        {
            int Id = 3;
            string firstName = "SARA";
            string lastName = "Nasiri";
            string discription = "Good";
            Person assignee = new Person(Id, firstName, lastName);

            ToDo todo = new ToDo(Id, discription, assignee);
            TodoService result = new TodoService();

            Assert.Equal(todo , result.FindById(3));
        }




        [Fact]
        public void CreatPtodoTest()
        {
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            int Id = 6;
            string discription = "good";
            Person assignee = new Person(Id, firstName, lastName);
            ToDo [] todoArray = new ToDo [3];

            TodoService todoService = new TodoService ();


            int ActualLenghtofArrayResult =todoService.CreatToDo (todoArray,Id, discription, assignee ).Length;
            Assert.Equal(todoArray.Length + 1, ActualLenghtofArrayResult);

        }


        [Fact]

        public void ClearTest()
        {
            ToDo [] todoArray = new ToDo [3];
            TodoService todoService = new TodoService();

            todoService .Clear();
            foreach (ToDo todo in todoArray )
            {
                Assert.Null(todo);
            }

        }

       

        [Fact]
        public void FindByDoneStatusTests()
        {
            bool done = false;
            
            ToDo[] todoArray = new ToDo [3];
            TodoService result = new TodoService();

            Assert.Equal(todoArray, result.FindByDoneStatus(done ));
        }

        


        [Fact]
        public void FindByAssigneeTests()
        {


            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            int Id = 6;

            TodoService todoService = new TodoService();
            Person assignee = new Person(Id ,firstName ,lastName );
            TodoService result = new TodoService();
            ToDo[] TOdOArray = new ToDo[0];


            Assert.Equal(TOdOArray ,result.FindByAssignee(Id));
        }


    }
}
