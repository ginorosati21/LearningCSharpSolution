using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class VariablesAndDataTypes
    {

        [Fact]
        public void SomeOfTheBuiltInTypes()
        {
            //Type Identifier
            int age;
            age = 22;
            Int32 yourAge;
            yourAge = 23;
            string name;
            name = "Jeff";
            String yourName = "Gino";

            //Initializing - assigning a value when declaring
            Double pay = 33.22;
            decimal yourPay = 33.22M;  //M just means decimal

            Boolean isAwake = true;
            bool over = 12 > 13;

            int x = 0;

            Assert.Equal(0, x);

        }

        string Thingy = "Tacos"; // class level variable
        [Fact]
        public void ImplicitlyTypedLocalVariables()
        {
            //C# 3.0
            Assert.Equal("Tacos", Thingy);

            //must initialize implicit variables
            //the compiler replaces the var with a decimal in the IL code
            var pay = 32.50M;

            //c# is  astrictly types language. A variable can never change
            // its data type. Born an integer? You will always be an integer
            //born an employee? you will never be a retiree

        }

        [Fact]
        public void ValueTypes()
        {
            //structs

            int age = 52;

            DoubleIt(age);
            Assert.Equal(52, age);
        }

        public void DoubleIt(int x)
        {
            x = x + x;
        }

        [Fact]
        public void UsingRefAndOut()
        {
            //comment a block: ctrl + k, ctrl + c
            //uncomment a block: ctrl + k, ctrl + u

            int y = 50;
            DoubleItRef(ref y);
            Assert.Equal(100, y);

            int p;
            GimmeSomething(out p);
            Assert.Equal(42, p);
        }
        
        public void DoubleItRef(ref int x)
        {
            x = x + x;
        }

        public void GimmeSomething(out int z)
        {
            z = 42;
        }


        //Console.Write("What is your age: ");

        //    string enteredAge = Console.ReadLine();
        //int age;
        //    if (int.TryParse(enteredAge, out age))
        //    {
        //        if (age >= 21)
        //        {
        //            Console.WriteLine("Old enough");

        //        }
        //        else
        //        {
        //            Console.WriteLine("No Admittance");
        //        } 
        //    } else
        //    {
        //        Console.WriteLine(age);
        //        Console.WriteLine("Enter a number, fool!");
        //    }
    }


    public struct Point
    {
        // main limitation of struct: you cannot extend them 

        //Structs create Stack Value Types
        //Classes create Heap Value References
    }
}
