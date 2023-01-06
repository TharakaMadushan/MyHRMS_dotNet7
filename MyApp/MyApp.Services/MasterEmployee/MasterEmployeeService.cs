using MyApp.DataAccess;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
