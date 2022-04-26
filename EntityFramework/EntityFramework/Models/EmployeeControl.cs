using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AppContext = TodaysTask.DataAcsess.AppContext;
namespace TodaysTask.Models
{
    public class EmployeeControl
    {

        private readonly AppContext _context;

        public EmployeeControl()
        {
            _context = new AppContext();
        }
        //DESKTOP-4EOUDP3
        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        //1
        public void GetEmployeeById(int id)
        {
            Employee empployee = _context.Employees.Find(id);
            Console.WriteLine(empployee.FullName);
            _context.SaveChanges();

        }
        //2
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
            _context.SaveChanges();
        }

        //3
        public void AddEmployee(string fullname)
        {
            Employee emp = new Employee { FullName = fullname };
            _context.Employees.Add(emp);
            _context.SaveChanges();

        }
        //4
        public void DeleteEmployee(int id)
        {

            Employee empployee = _context.Employees.Find(id);
            if (empployee != null)
            {
                _context.Employees.Remove(empployee);
            }
            else
            {
                Console.WriteLine("This employee is null");
            }
            _context.SaveChanges();

        }

        //5
        public void FilterByName(string search)
        {

            List<Employee> emplist = _context.Employees.ToList();
            bool IsExist = false;
            foreach (var item in emplist)
            {
                if (item.FullName.ToLower().Contains(search) || item.FullName.ToUpper().Contains(search))
                {
                    Console.WriteLine(item.FullName);
                    IsExist = true;
                }
                else
                {
                    IsExist = false;
                }
            }
            if (!IsExist)
            {
                Console.WriteLine("Bele bir ishci yoxdur");
            }

        }

    }

}

