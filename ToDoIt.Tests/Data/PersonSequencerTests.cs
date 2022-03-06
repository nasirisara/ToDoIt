using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;


namespace ToDoIt.Tests.Data
{
    public class PersonSequencerTests
    {
        [Fact]
        public void NextPersonTest()
        {
            int Id = 1;


            Assert.Equal(2, PersonSequencer.NextPersonId(Id));

        }
        [Fact]
        public void ResetTest()
        {

            int Id = 3;
            int resetWorks = PersonSequencer.Reset(Id);

            Assert.Equal(0, resetWorks);

        }


    }
}
