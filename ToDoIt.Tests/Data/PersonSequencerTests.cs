using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;
using ToDoIt.Models;


namespace ToDoIt.Tests.Data
{
    public class PersonSequencerTests
    {
        [Fact]
        public void NextPersonTest()
        {
            


            Assert.Equal(1, PersonSequencer.NextPersonId());

        }
        [Fact ]
        public void ResetTest()
        {

            PersonSequencer.Reset();
            string firstName = "Sara";
            string lastName = "Nasiri";
            Person result = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            

            Assert.Equal(1, result.Id);

        }


    }
}
