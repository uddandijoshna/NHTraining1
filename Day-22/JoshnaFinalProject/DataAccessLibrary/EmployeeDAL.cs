using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class EmployeeDAL
    {
        public static string filepath = "E:\\NHTraining1\\Day-22\\Employees.txt";
        private static int id;

        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            try
            {
                String textContent = String.Concat(empId, ",", empName, ",", empSalary, ",", empAge, ",");
                File.AppendAllText(filepath, textContent + Environment.NewLine);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public static List<string> GetEmployeesById(int empId)
        {
            var allEmployees = File.ReadAllLines(filepath);
            // bool isFound = false;
            List<string> employeeFound = new List<string>();

            foreach (String employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == id)

                {
                    //  isFound = true;
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;
        }
            public static List<string> GetEmployeesByName(string empName)
            {
                var allEmployees = File.ReadAllLines(filepath);

                List<string> employeeFound = new List<string>();

                foreach (String employee in allEmployees)
                {
                    var empDetails = employee.Split(',');
                    if (empDetails[1].Contains(empName))
                    {

                        employeeFound.Add(employee);

                    }

                }
                return employeeFound;
               
            }
            public static String[] GetAllEmployees()
            {
                var allEmployees = File.ReadAllLines(filepath);
                return allEmployees;
            }


    }
}


