using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

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
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers - Done

            var sumNumber = numbers.Where(x => x > 0).Sum();
            {
                Console.WriteLine(sumNumber);
            }

            var avgNumber = numbers.Where(x => x > 0).Average();
            {
                Console.WriteLine(avgNumber);
            }



            //Order numbers in ascending order and decsending order. Print each to console.b- Done 

            IEnumerable<int> decNumber = numbers.OrderByDescending(x => x).ToArray();
            {
                foreach (int x in numbers)
                {
                    Console.WriteLine(x);
                }
            }

            IEnumerable<int> ascNumber = numbers.OrderBy(number => number);
            {
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

            //Print to the console only the numbers greater than 6 - Done

            IEnumerable<int> xNumber = numbers.Where(number => number > 6).ToArray();
            {

                foreach (var number in numbers)

                    if (number > 6)

                    {
                        Console.WriteLine(number);
                    }
            }




            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!** - Done 

            IEnumerable<int> num = numbers.OrderBy(number => number).Take(4);

            {
                foreach (var number in num)

                {
                    Console.WriteLine(number);

                }

            }




            //Change the value at index 4 to your age, then print the numbers in decsending order - Done 

            numbers[4] = 42;

            foreach (var item in numbers.OrderByDescending(num2 => num2))
            {

                Console.WriteLine(item);
            }



            {

                // List of employees ***Do not remove this***
                var employees = CreateEmployees();

                //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S. -Done 
                var employeeList = employees.Where(person => person.FirstName.StartsWith('C') || person.FirstName.StartsWith('S'));

                Console.WriteLine($"The employees with the letter C or S in their first name are as follows:");
                Console.WriteLine($"**********************************************************************");

                foreach (var person in employeeList)
                {

                    Console.WriteLine($"Name: { person.FullName}, Age { person.Age}");

                }



                //Order this in acesnding order by FirstName. - Done 



                //Print all the employees' FullName and Age who are over the age 26 to the console - Done 

                var overTwentySix = employees.Where(person => person.Age > 26).OrderBy(person => person.Age).ThenBy(person => person.FirstName);
                Console.WriteLine($"The employees who are over the age of 26 are as follows:");
                Console.WriteLine($"**********************************************************************");

                foreach (var person in overTwentySix)

                {

                    Console.WriteLine($"Name: { person.FullName}, Age { person.Age}");


                }
                //Order this by Age first and then by FirstName in the same result. - Done 

                //Print the Sum and then the Average of the employees' YearsOfExperience
                //if their YOE is less than or equal to 10 AND Age is greater than 35 - DONE

                var experienceSum = employees.Sum(person => person.YearsOfExperience);

                var experienceAvg = employees.Average(person => person.YearsOfExperience);

                var experienclvl = employees.Where(person => person.YearsOfExperience <= 10 && person.Age > 35);

                foreach (var person in experienclvl)

                {

                    Console.WriteLine($"Name: { person.FullName}, Age { person.Age}, YOE: {person.YearsOfExperience}");

                }






                //Add an employee to the end of the list without using employees.Add()


                //Console.WriteLine();

                //Console.ReadLine();
            }
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

