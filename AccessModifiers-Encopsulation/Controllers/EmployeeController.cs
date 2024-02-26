using AccessModifiers_Encopsulation.Helpers.Constans;
using AccessModifiers_Encopsulation.Models;
using AccessModifiers_Encopsulation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Encopsulation.Controllers
{
    internal class EmployeeController
    {
        public readonly EmployeeService employeeService;
        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }
        public void GetAll()
        {
            

            var result = employeeService.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.name+" " + item.surname);
            }

        }
        public void GetAllByAge()
        {

            
            var employees = employeeService.GetAll();
            var result = employeeService.GetAllByAge(employees,30);
            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname +" " +item.age);
            }
        }
        public void GetCountByAge()
        {
            Console.WriteLine("Add first age");
            int firstAge=int.Parse(Console.ReadLine());

            Console.WriteLine("Add last age");
            int lastAge = int.Parse(Console.ReadLine());

            int  count = employeeService.GetCountByAge(employeeService.GetAll(), firstAge, lastAge);
            Console.WriteLine(count);
        }
        public void SumOfAge()
        {
            
            int sumOfage = employeeService.SumOfAge(employeeService.GetAll());
            Console.WriteLine(sumOfage);
        }
        public void GetAllByCheckedEmail()
        {
            Console.WriteLine("Add your text:");
            string str=Console.ReadLine();
            Employee[] employees=employeeService.GetAll();
            var checkedEmployees=employeeService.GetAllByCheckedemail(employees,str);
            if (checkedEmployees.Count() == 0)
            {
                //break ve returnun ferqi break loopu dayandirir return metodu dayandirir
                Console.WriteLine(RespnceMesages.Notfound);
                return;
            }
            foreach (var  item in checkedEmployees)
            {
                Console.WriteLine(item.name+" " + item.surname+" "+item.email);
            }
        }
    }
}
