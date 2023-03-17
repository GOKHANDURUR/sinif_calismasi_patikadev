using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statik_sinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //When you access this static member static constructor start one time and thats enough.

            Console.WriteLine("Number of Workers is {0}", Employee.EmployeeNumber);

            Employee employee = new Employee("Müslüm", "Nickişenses", "IT");
            Console.WriteLine("Number of Workers is {0}", Employee.EmployeeNumber);
            Employee employeeTwo = new Employee("Gülcan", "Patlıcan", "IT");
            Employee employeeThree = new Employee("Borcam", "Napcan", "IT");
            Console.WriteLine("Number of Workers is {0}", Employee.EmployeeNumber);

            //You can access this class only using this syntax. New keyword doesn't work.
            Console.WriteLine("Sum of two numbers are : {0}", MathOperations.Sum(100, 200));
            Console.WriteLine("Extraction of two numbers are : {0}", MathOperations.Subtrac(200, 50));

        }
    }

    class Employee
    {
        private static int employeeNumber;

        public static int EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }

        private string Name;
        private string LastName;
        private string Department;

        static Employee()
        {
            employeeNumber = 0;
        }

        public Employee(string name, string lastName, string department)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Department = department;
            employeeNumber++;
        }

    }

    static class MathOperations
    {
        public static long Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static long Subtrac(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
    

