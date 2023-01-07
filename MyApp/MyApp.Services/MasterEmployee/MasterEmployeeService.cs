using MyApp.DataAccess;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services.MasterEmployee
{
    public class MasterEmployeeService : IMasterEmployee
    {
        private readonly MyDbContext _context = new MyDbContext();

        

        public List<Employees> GetAllEmployees()
        {
            return _context.MasterEmployees.ToList();
        }

        public Employees GetEmployee(int empNo)
        {
            return _context.MasterEmployees.Find(empNo);
        }

        public Employees CreateEmployee(Employees employee)
        {
            _context.MasterEmployees.Add(employee);
            _context.SaveChanges();

            return _context.MasterEmployees.Find(employee.EmployeeNo);
        }

        public void UpdateEmployee(Employees employee)
        {
            _context.SaveChanges();
        }

        public void DeleteEmployee(Employees employees)
        {
            _context.Remove(employees); 
            _context.SaveChanges();
        }
    }
}
