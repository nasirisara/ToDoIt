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
            

            TodoService todoService  = new TodoService ();
            int result = todoService.Size();
            ToDo[] resulyArray = todoService.FindAll();

            Assert.Equal(resulyArray .Length ,result );
        }


        [Fact]
        public void FindByIdTrueTest()
        {

            string firstName = "SARA";
            string lastName = "Nasiri";
            string discription = "Good";
            Person assignee = new Person(PersonSequencer.NextPersonId(), firstName, lastName);

            ToDo todonew = new ToDo(TodoSequencer.NextTodoId(), discription, assignee);
            TodoService todoService = new TodoService();
            ToDo[] resulyArray = todoService.FindAll();

            foreach (ToDo todo in resulyArray)
            {
                Assert.Equal(todonew, todoService.FindById(TodoSequencer.NextTodoId()));
            }

        }




        [Fact]
        public void CreattodoTest()
        {
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            string discription = "good";
            Person assignee = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            TodoService todoService = new TodoService ();

            ToDo result = todoService.CreatToDo ( discription, assignee );
            ToDo[] resultArray = todoService.FindAll();

            Assert.Contains(result, resultArray);
            Assert.Equal(discription, result.Description);
        }


        [Fact]

        public void ClearTest()
        {
            
            TodoService todoService = new TodoService();

            todoService .Clear();
            foreach (ToDo todo in todoService .FindAll () )
            {
                Assert.Null(todo);
            }

        }

       

        [Fact]
        public void FindByDoneStatusTests()
        {
            bool done = false;
            
           
            TodoService result = new TodoService();
            ToDo[] resultArray = result.FindAll();
            Assert.Equal(resultArray  , result.FindByDoneStatus(done ));
        }




        [Fact]
        public void FindByAssigneeTests()
        {


            string firstName = "Fatemeh";
            string lastName = "Sojudi";

            Person assignee = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            TodoService todoService = new TodoService();

            ToDo[] resultArray = todoService.FindAll();

            Assert.Equal(resultArray, todoService.FindByAssignee(assignee));
        }


    }
}
