using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Models;

namespace ToDoIt.Data
{
    public class TodoService
    {
        private static ToDo [] toDoArray = new ToDo [0];
       
        public int Size()
        {
            int ArrayLenght = toDoArray.Length;
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

        public ToDo CreatToDo( string discription, Person assignee)
        {
            ToDo nextToDo = new ToDo (TodoSequencer.NextTodoId(), discription , assignee );

            Array.Resize<ToDo >(ref toDoArray, toDoArray.Length + 1);
            toDoArray[toDoArray.Length - 1] = nextToDo;
            return nextToDo;
        }

        public void Clear()
        {
            Array.Clear(toDoArray, 0, toDoArray.Length);
        }


        public ToDo[] FindByDoneStatus(bool doneStatus)
        // Returns array with objects that has a matching done status
        {
            List<ToDo> foundToDos = new List<ToDo>();
            
            foreach (ToDo toDo in toDoArray )
            {
                if (doneStatus == toDo .Done)
                {
                    foundToDos.Add(toDo);
                }
             
            }
            return foundToDos.ToArray();
        }

        public ToDo[] FindByAssignee(int personId)
       
        { //– Returns array with ToDo´s that has an assignee with a matching id.
          
            List<ToDo> foundToDos = new List<ToDo>();

            foreach (ToDo  todo in toDoArray )
            {

                if (personId ==todo.Assignee.Id)
                {
                    foundToDos.Add (todo );
                }
            }
            return foundToDos .ToArray ();

        }

        public ToDo[] FindByAssignee(Person assignee)
        //Returns array with ToDo´s that has this Person as its assignee. 
        {
            return FindByAssignee(assignee.Id);//DRY
        }
        public ToDo[] FindUnassignedTodoItems(Person assignee)
        // Returns an array of ToDo´s that does not have an assignee set to it.

        {
            List<ToDo> foundToDos = new List<ToDo>();

            foreach (ToDo todo in toDoArray)
            {
                if (assignee != todo.Assignee)
                {
                    foundToDos.Add(todo );
                }
            }
            return foundToDos .ToArray ();

        }

    }
}
