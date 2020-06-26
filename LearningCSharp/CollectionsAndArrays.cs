using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class CollectionsAndArrays
    {
        [Fact]
        public void UsingAnOldSkoolArrayList()
        {
            var favoriteNumbers = new ArrayList();
            favoriteNumbers.Add(21);
            favoriteNumbers.Add(24);
            favoriteNumbers.Add(5);
            favoriteNumbers.Add(17);

            Assert.Equal(21, favoriteNumbers[0]);

            favoriteNumbers[1] = 22;
            Assert.Equal(22, favoriteNumbers[1]);

            Assert.Throws<ArgumentOutOfRangeException>(
                () => favoriteNumbers[99]);

            favoriteNumbers.Add("Tacos");
            var firstTwo = (int)favoriteNumbers[0] + (int)favoriteNumbers[1];
            Assert.Equal(43, firstTwo);
        }

        [Fact]
        public void UsingGenericList()
        {
            //List of int - generics prvide parametric polymorphism (shape is based on parameter)
            var favoriteNumbers = new List<int>();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(10);
            var firstTwo = favoriteNumbers[0] + favoriteNumbers[1];
            Assert.Equal(19, firstTwo);

        }

        [Fact]
        public void InitializingAndEnumeratingAList()
        {
            var friends = new List<string>
            {
                "Sean",
                "Tim",
                "Amy",
            };
            string friendString = "";
            foreach(string friend in friends)
            {
                friendString += friend;
            }
            Assert.Equal("SeanTimAmy", friendString);
        }

        [Fact]
        public void EnumerateStrings()
        {
            //first - the char data type
            char mi = 'm'; // a single unicode character 916 bits)
            //delimited by single quotes

            string message = "Call your mon";
            Assert.Equal('C', message[0]);

            foreach(char c in message)
            {
                //you would have each character in sequence here
            }
        }

        [Fact]
        public void StringsAreImmutable()
        {
            //// this means you cannot change a string
            //string myName = "Gino";
            //myName += "Rosati";

            //Assert.Equal("Gino Rosati", myName);

            //StringBuilder result = new StringBuilder();
            //foreach(var num in Enumerable.Range(1, 1000))
            //{
            //    result.Append(num.ToString());
            //}
        }

        [Fact] 
        public void UsingADictionary()
        {
            var friends = new Dictionary<char, string>();
            friends.Add('s', "Sean");
            friends.Add('d', "David");

            Assert.Equal("David", friends['d']);
        }

        [Fact]
        public void InitializingAndEnumeratingADictionary()
        {
            var friends = new Dictionary<char, string>()
            {
                {'s', "Sean" },
                {'d', "David" },
                {'b', "Sean" }
            };

            Assert.Equal("David", friends['d']);
            Assert.True(friends.ContainsKey('d'));
            Assert.False(friends.ContainsValue("Billy"));

            foreach(char c in friends.Keys)
            {
                // you have the key here
            }

            foreach(string f in friends.Values)
            {
                //you have the values here
            }

            foreach(KeyValuePair<char, string> kvp in friends)
            {
                //you have the keyvalue pair
                //kvp.key = 's', 'd', 'b'
                //kvp.value = "Sean", "David", "Sean"
            }
        }

        [Fact]
        public void ArraysAreCoolButLimited()
        {
            string[] friends = new string[] { "Joe", "Bill", "Sue", "Mary" };
            Assert.Equal("Joe", friends[0]);

            //but you can't add elements t the array. this array will always have 4 elements in it

            var luckyNumbers = new int[3];
            luckyNumbers[0] = 9;
            luckyNumbers[1] = 21;
            luckyNumbers[2] = 17;
        }
    }
}
