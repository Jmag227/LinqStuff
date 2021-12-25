using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 0 };

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
            var av = numbers.Average();
            Console.WriteLine($"{sum}\n{av}");
            Console.WriteLine();

            //Order numbers in ascending order and decsending order. Print each to console.

            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();                   
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            //Print to the console only the numbers greater than 60

            Console.WriteLine();
            numbers.Where(X => X > 60).ToList().ForEach(x => Console.WriteLine(x));

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine();
            numbers.Where(x => x > 50).ToList().ForEach(x => Console.WriteLine(x));

            //Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine();
            numbers[4] = 21;
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.

            Console.WriteLine();
            var filter = employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName);
            filter.ToList().ForEach(x => Console.WriteLine(x.FullName));



            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            Console.WriteLine();
            var filterAge = employees.Where(x => x.Age > 26);
            filterAge.OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine();
            var emp = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var sumEmp = emp.Sum(x => x.YearsOfExperience);
            var average = emp.Average(x => x.YearsOfExperience);
            Console.WriteLine($"Sum {sumEmp}\nAverage {average}");

            //Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Jarom", "Magalei", 21, 1)).ToList();
            Console.WriteLine();
            employees.ToList().ForEach(x => Console.WriteLine($"{x.FullName} {x.YearsOfExperience}"));
          
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
