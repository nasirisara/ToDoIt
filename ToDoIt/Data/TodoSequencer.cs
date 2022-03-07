using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Models;

namespace ToDoIt.Data
{
    public class TodoSequencer
    {
        private static int todoId;
 
        public static int NextTodoId()
        {
            return ++todoId;
        }
        public static void Reset()
        {
            todoId = 0;
        }



    }
}
