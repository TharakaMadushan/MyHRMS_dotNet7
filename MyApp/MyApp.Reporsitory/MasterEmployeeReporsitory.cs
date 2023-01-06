using MyApp.DataAccess;
using MyApp.IReporsitory;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Reporsitory
{
    public class MasterEmployeeReporsitory : IMasterEmployee
    {
        private readonly MyDbContext _context = new MyDbContext();

        public List<MasterEmployee> GetAllEmployees()
        {
            return _context.MasterEmployees.ToList();
        }
    }
}
