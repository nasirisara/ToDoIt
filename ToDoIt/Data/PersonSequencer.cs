using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    public class PersonSequencer
    {
        private static int personId;

        public PersonSequencer(int PersonId)
        {
            PersonId = personId;
        }

        public int Id
        {
            get { return personId; }//get/read
        }
        public static int NextPersonId(int NextPersonId)
        {

            return ++(NextPersonId);


        }
        public static int Reset(int personId)
        {
            personId = 0;
            return personId;

        }



    }
}
