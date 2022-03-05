

using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt_Assignment.Models;

namespace ToDoIt_Assignment.Models
{
    public class ToDo
    {
        private int id;
        private string description;
        private bool done;
        Person assignee;

        public ToDo(int id, string description, Person assignee)
        {
            this.id = id;
            this.description = description;
            this.assignee = assignee;

        }
        public int Id
        {
            get { return id; }

        }

        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Discription Can not be empty .");
                }
                else
                {
                    description = value;
                }
            }
        }
        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }






    }
}
