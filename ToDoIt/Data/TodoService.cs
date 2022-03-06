using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Models;

namespace ToDoIt.Data
{
    public class TodoService
    {
        private static ToDo [] toDoArray = new ToDo [0];
        private readonly int Id;
        private readonly string firstName;
        private readonly string  lastName;
        private readonly string discription;
        private readonly Person assignee;


        public ToDo[] ToDoArray
        {
            get { return toDoArray; }
            set { toDoArray = value; }
        }


        public int Size(ToDo [] toDoArraysize)
        {
            int ArrayLenght = toDoArraysize.Length;
            return ArrayLenght;
        }
        public ToDo [] FindAll()
        {
            return toDoArray;
        }

        public ToDo  FindById(int personId)
        {
              
            foreach (ToDo toDo in toDoArray)
            {
                if (toDo.Id == personId)
                {
                    return toDo;
                }

            }

            return null;

        }
        public int PersonId(int Id)
        {
            return PersonSequencer.NextPersonId(Id);
        }

        public ToDo[] CreatToDo(ToDo [] increasedToDoArray,int Id, string discription, Person  assignee )
        {


            ToDo nextToDo = new ToDo (PersonId(Id), discription , assignee );

            Array.Resize<ToDo >(ref increasedToDoArray, increasedToDoArray.Length + 1);
             nextToDo = increasedToDoArray[increasedToDoArray.Length - 1];
            return increasedToDoArray;
        }

        public void Clear()
        {
            Array.Clear(toDoArray, 0, toDoArray.Length);
        }


        public ToDo[] FindByDoneStatus(bool doneStatus)
        // Returns array with objects that has a matching done status
        {

            
            foreach (ToDo toDo in toDoArray )
            {
                if (doneStatus == toDo .Done)
                {
                    return toDoArray;
                }
             
            }
            return null;
        }

        public ToDo[] FindByAssignee(int personId)
       
        {
            //– Returns array with ToDo´s that has an assignee with a matching id.
            Person assignee = new Person(Id, firstName, lastName);
            foreach (ToDo  todo in toDoArray )
            {

                if (personId == assignee.Id)
                {
                    return toDoArray;
                }
            }
            return null;

        }

        public ToDo[] FindByAssignee(Person assignee)
        //Returns array with ToDo´s that has this Person as its assignee. 
        {
            ToDo toDo = new ToDo(Id, discription, assignee);
            foreach (ToDo todo in toDoArray)
            {
                if (assignee == toDo.Assignee)
                {
                    return toDoArray;
                }
            }
            return null;
        }
        public ToDo[] FindUnassignedTodoItems()
        // Returns an array of ToDo´s that does not have an assignee set to it.

        {
            
            foreach (ToDo todo in toDoArray)
            {
                if (assignee != todo.Assignee)
                {
                    return toDoArray;
                }
            }
            return null;

        }

    }
}
