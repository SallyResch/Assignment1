using System;
using System.Collections.Generic;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Add Employee ");
            Console.WriteLine("2. Show Registered employees ");
            Console.WriteLine("3. Exit program ");

            string option = Console.ReadLine();
            int choice = int.Parse(option);

            if (choice == 1)
            {
                Console.WriteLine("Add the name of the employee: ");
                string name = Console.ReadLine();
                Console.WriteLine("Add the salary of the employee: ");
                double salary = double.Parse(Console.ReadLine());
                Employee newEmployee = new Employee(name, salary);
                employees.Add(newEmployee);
                Console.WriteLine("Employee added to list");

            }
            else if (choice == 2)
            {
                Console.WriteLine("Registered Employees List: ");
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("You exited the program");
                return;
            }
            else 
            {
                Console.WriteLine("Invalid option. Please choose a valid option.");
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}

