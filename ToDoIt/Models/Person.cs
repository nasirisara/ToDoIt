using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt_Assignment.Models
{
    public class Person

    {
        private readonly int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;

            this.Firstname = firstName;
            this.Lastname = lastName;

        }

        public int Id
        {
            get { return id; }//get/read
        }


        public string Firstname
        {
            get { return firstName; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Firstname must contains at least one letter");
                }
                else//its okay
                {
                    firstName = value;
                }
            }

        }
        public string Lastname
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Lastname  must contains at least one letter");

                }
                else
                {
                    lastName = value;
                }
            }
        }


    }


}
