using System;
using System.Collections.Generic;


namespace LearningCSharp
{
    public class NumberFilter
    {

        //create a class that extends System.MultiCastDelegate
        //that can refer to any method that takes an int and returns a bool
        public delegate bool FilterMethod(int num);

        public List<int> FilterOutEvens(List<int> numbers)
        {
            // return Filter(numbers, IsOdd); // "Method Group"

            //anonymous method
            //does the same thing as IsOdd but is not needed
            //return Filter(numbers, delegate (int x)
            //{
            //    return x % 2 != 0;
            //});

            //lambdas
            // => is "goes to"; n goes to expression
            return Filter(numbers, n => n % 2 != 0);
        }

        public List<int> FilterOutOdds(List<int> numbers)
        {
            return Filter(numbers, IsEven);
        }

        public List<int> Filter(List<int> numbers, FilterMethod op)
        {
            var result = new List<int>();
            foreach (var num in numbers)
            {
                //calling op(x) is really calling op.Invoke(x)
                if (op(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }

        private bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        private bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}