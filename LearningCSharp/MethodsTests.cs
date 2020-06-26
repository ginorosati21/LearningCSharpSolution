using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class MethodsTests
    {
        [Fact]
        public void OverloadingMethods()
        {


            var methods = new MethodExamples();
            var fullName = methods.FormatName("Han", "Solo");
            Assert.Equal("Solo, Han", fullName);

            fullName = methods.FormatName("Han", "Solo", "D");
            Assert.Equal("Solo, Han D", fullName);

        }
        

        [Fact]
        public void Defaults()
        {
            var methods = new MethodExamples();
            Assert.Equal(4, methods.Add(2, 2));
            Assert.Equal(20, methods.Add(10));
            Assert.Equal(12, methods.Add());
        }

        [Fact] 
        public void UsingTheParams()
        {
            var methods = new MethodExamples();

            //1 becomes a, 2 becomes b, everything else is thrown into rest[]
            var total = methods.Add(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Assert.Equal(45, total);
        }
        
    }
}
