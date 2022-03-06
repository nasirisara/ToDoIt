using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    public class TodoSequencer
    {
        private static int todoId;

        public TodoSequencer(int TodoId)
        {
            TodoId = todoId;
        }

        public int Id
        {
            get { return todoId ; }//get/read
        }
        public static int NextTodoId(int NextTodoId)
        {

            return ++(NextTodoId);


        }
        public static int Reset(int resetTodoId)
        {
            resetTodoId = 0;
            return resetTodoId;

        }



    }
}
