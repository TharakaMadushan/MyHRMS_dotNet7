using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.IReporsitory
{
    public interface IMasterEmployee 
    {
        public List<MasterEmployee> GetAllEmployees();
    }
}
