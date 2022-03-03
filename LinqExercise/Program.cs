using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            var sum = numbers.Sum();
            var avg = numbers.Average();
            Console.WriteLine($"\nThis is the the total of all numbers in the array: {sum} \nSame numbers average: {avg}\n");

            //Order numbers in ascending order and decsending order. Print each to console.
            Console.WriteLine("\nNumbers array in descending order: ");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nNumbers array in ascending order: ");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

            //Print to the console only the numbers greater than 6
            Console.WriteLine("\nNumbers from the list that are  greater than 6: ");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("\n4 numbers from the given array: ");
            foreach (var num in numbers.Take(4))
            {
                Console.WriteLine(num);
            }

            //Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("\nArray with index = 4 replaced with my age and sorted in descending order: ");
            numbers.SetValue(42, 4);
            var descWithAge = numbers.OrderByDescending(num => num);
            foreach (var number in descWithAge)
            {
                Console.WriteLine(number);
            }


            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.

            Console.WriteLine("\n\nEmployees with First Name starting with C or S in ascending order: ");
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList().ForEach(x => 
                {
                    Console.Write ($"First Name: {x.FirstName}  ");
                    Console.WriteLine($"Last Name: {x.LastName}");
                });


            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.

            Console.WriteLine("\n\nEmployees over 26 y.o. in ascending order by age and first name: ");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x =>
            {
                Console.WriteLine($"Full Name: {x.LastName}, {x.FirstName} Employee Age: {x.Age};");
            });



            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("\n\n");
            var answer = employees.Where(x => x.YearsOfExperience <= 10 || x.Age > 35);
            int sumYoExp = answer.Sum(x => x.YearsOfExperience);
            Console.WriteLine($"Sum of Years of experience: {sumYoExp}");
            double avgYoExp = answer.Average(x => x.YearsOfExperience);
            Console.WriteLine($"Average of Years of experience: {avgYoExp}");

            Console.WriteLine("\n\n <3  Thank You! This was fun!  <3");

            //Add an employee to the end of the list without using employees.Add()


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
