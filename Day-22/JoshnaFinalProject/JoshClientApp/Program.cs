using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;
using System.IO;

namespace JoshClientApp
{
    public class Program
    {
        private static int id;

        static void Main(string[] args)
        {
            int ch;
            string choice;

            do
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("*********************************************");
                Console.WriteLine("1.Add Employee:");
                Console.WriteLine("2.Search Employee By Id:");
                Console.WriteLine("3.Search Employee By Name:");
                Console.WriteLine("4.Display All Employees:");
                Console.WriteLine("Enter your choice:");
                ch = Convert.ToInt32(Console.ReadLine());

                switch(ch)
                { 
                    case 1:
                    AddEmployee();
                    break;
                case 2:
                    SearchEmployeeById();
                    break;
                case 3:
                    SearchEmployeeByName();
                    break;
                case 4:
                    DisplayAllEmployees();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;

                }
                Console.WriteLine("Do you Want to continue (y/n):");
                choice = Console.ReadLine();
            } while (choice.Equals("y"));
        }
        public static void AddEmployee()
        {
            int Id, Salary, Age;
            string name;
            Console.WriteLine("Enter Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Salary:");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            name =( Console.ReadLine());
            //call BLL Method
            var result = EmployeeBLL.AddEmployee(id, name, Salary, Age);

            if (result)
                Console.WriteLine("Employee Details Saved Successfully");
            else
                Console.WriteLine("Some error occured");

        }
        public static void SearchEmployeeById()
        {
            int Id;
            Console.WriteLine("Enter Id:");
            Id = Convert.ToInt32(Console.ReadLine());
            var result = EmployeeBLL.GetEmployeesById(Id);
            if (result.Count == 0)
                Console.WriteLine("No records exists with this Id");
            else
            {
                result.ForEach(p => Console.WriteLine(p));

            }

        }
        public static void SearchEmployeeByName()
        {
            string Name;
            Console.WriteLine("Enter Name:");
            Name=Console.ReadLine();
            List<string> result = EmployeeBLL.GetEmployeesByName(Name);
            if (result.Count == 0)
                Console.WriteLine("The Employees Details,Found with Given Name");
            else
            {
                result.ForEach(p => Console.WriteLine(p));

            }
        }
        public static void DisplayAllEmployees()
        {
            var employees = EmployeeBLL.GetAllEmployees();
            Console.WriteLine("Displaying All Employee Details in the Record");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}







        