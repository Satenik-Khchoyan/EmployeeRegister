using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    class EmployeeList
    {
        private readonly List<Employee> employees;

        public EmployeeList()
        {
            employees = new List<Employee> ();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> DisplayEmployeeList()
        {
            return employees;
        }

        

        
    }
}
