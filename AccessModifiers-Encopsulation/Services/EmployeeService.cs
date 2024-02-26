using AccessModifiers_Encopsulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Encopsulation.Services
{
    internal class EmployeeService : Employee
    {
        public Employee[] GetAll()
        {
            Employee employe1 = new()
            {
                id = 1,
                name = "Test",
                surname = "Testov",
                address = "Testcity",
                email = "testcity@gmail.com",
                age = 42
            };
            Employee employe2 = new()
            {
                id = 2,
                name = "Test1",
                surname = "Testov1",
                address = "Testcity1",
                email = "testcity1@gmail.com",
                age = 22
            };
            Employee employe3 = new()
            {
                id = 3,
                name = "Test2",
                surname = "Testov2",
                address = "Testcity2",
                email = "testcity2@gmail.com",
                age = 23
            };
            Employee[] employers = { employe1, employe2, employe3 };
            return employers;
        }
        public Employee[] GetAllByAge(Employee[] employees, int age)
        {
            return employees.Where(m => m.age > age).ToArray();
        }
        public int GetCountByAge(Employee[] employees, int firstAge, int lastAge)
        {
            return employees.Where(m => m.age > firstAge && m.age < lastAge).Count();
        }
        public int SumOfAge(Employee[] employees)
        {
            return employees.Sum(m => m.age);
        }
        public Employee[] GetAllByCheckedemail(Employee[] employees, string str)
        {
            return employees.Where(m=> m.email.StartsWith(str)).ToArray();
        }
    }
}
