using System;

namespace EmployeeRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EmployeeList list = new EmployeeList();

            Console.WriteLine("Please type Add if you want to add an employee or Display if you want to see the employee list or Exit to exit.");
            string input ;

            do
            {
                input = Console.ReadLine();
                if (input.Equals("Add"))
                {
                    Employee employee = new Employee();
                    Console.WriteLine("Enter the name of employee.");
                    employee.Name = Console.ReadLine();
                    Console.WriteLine("Enter the salary of employee.");
                    employee.Salary = int.Parse(Console.ReadLine());
                    list.AddEmployee(employee);
                }
                else
                {
                    if (input.Equals("Display"))
                    {
                        if (list.Equals(null))
                            Console.WriteLine("List is empty.");
                        else
                        {
                            list.DisplayEmployeeList();
                            foreach (Employee item in list.DisplayEmployeeList().ToArray())
                            {
                                Console.WriteLine(item.Name + " " + item.Salary);
                            }
                        }
                    }
                    
                }
            } while (!input.Equals("Exit"));
        }
    }
}
