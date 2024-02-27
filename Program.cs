using System;
using System.Collections.Generic;

namespace Assignment1
{
    internal class Program
    {

        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Add Employee ");
            Console.WriteLine("2. Show Registered employees ");
            Console.WriteLine("3. Exit program ");

            while (true)
            {
                string option = Console.ReadLine();
                int choice = int.Parse(option);

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ShowEmployees();
                        break;
                    case 3:
                        Console.WriteLine("You exited the program");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }

 
        static void AddEmployee()
        {
            Console.WriteLine("Add the name of the employee: ");
            string name = Console.ReadLine();
            Console.WriteLine("Add the salary of the employee: ");
            double salary = double.Parse(Console.ReadLine());
            Employee newEmployee = new Employee(name, salary);
            employees.Add(newEmployee);
            Console.WriteLine("Employee added to list");
        }


        static void ShowEmployees()
        {
            Console.WriteLine("Registered Employees List: ");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
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


