using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services.MasterEmployee
{
    public interface IMasterEmployee
    {
        public List<Employees> GetAllEmployees();
        public Employees GetEmployee(int id);
        public Employees CreateEmployee(Employees employee);
        public void UpdateEmployee(Employees employee);
        public void DeleteEmployee(Employees employee);
    }
}
