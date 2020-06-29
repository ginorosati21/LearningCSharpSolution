using System;
using System.Collections.Generic;
using System.Text;



namespace LearningCSharp.Hr
{
    public class Employee : Person
    {
        

        public decimal Salary { get; private set; } = 50000;

        public void GiveRaise(decimal amount)
        {
            Salary += amount;
        }

        public override string GetInfo()
        {
            if (IsHighlyCompensated())
            {
                return $"{FirstName} {LastName} is a highly paid employee with a salary of {Salary:c}";
            }
            else
            {
                return $"{FirstName} {LastName} is an employee with a salary of {Salary:c}";
            }

            //if it's within another method that means it's only used by the outer method, therefore it does not need an access identifier
            bool IsHighlyCompensated()
            {
                return Salary > 100000;
            }
        }

    }
}

namespace LearningCSharp.Hr
{
}