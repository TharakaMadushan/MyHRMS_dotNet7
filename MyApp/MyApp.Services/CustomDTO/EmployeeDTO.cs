﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services.CustomDTO
{
    public class EmployeeDTO
    {
        public int EmployeeNo { get; set; } 
        public string EmployeeFullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
