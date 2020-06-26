using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class ExtensionMethods
    {
        [Fact]
        public void UsingThem()
        {
            int x = 13;
            if(x.IsEven())
            {

            }


            string message = "Hello";
            Assert.Equal(2, message.CountVowels());
        }
    }
}   
