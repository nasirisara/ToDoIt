using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;


namespace ToDoIt.Tests.Data
{
    public class TodoSequencerTests
    {
        [Fact]
        public void NextTodoIdTest()
        {
            int Id = 1;


            Assert.Equal(2, TodoSequencer.NextTodoId(Id));

        }
        [Fact]
        public void ResetTest()
        {

            int Id = 3;
            int resetWorks = TodoSequencer.Reset(Id);

            Assert.Equal(0, resetWorks);

        }


    }
}
