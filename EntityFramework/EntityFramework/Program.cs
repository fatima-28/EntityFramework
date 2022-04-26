using System;
using System.Collections.Generic;
using TodaysTask.Models;

namespace TodaysTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeeControl emp1 = new EmployeeControl();
            //int id = int.Parse(Console.ReadLine());
            //emp1.DeleteEmployee(id);

            EmployeeControl emp = new EmployeeControl();

            string word = Console.ReadLine();

            emp.AddEmployee(word);


        }
    }
}
