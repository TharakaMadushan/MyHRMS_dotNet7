﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Reporsitory.DTO
{
    public class MasterEmployeeDTO
    {
        public int EmployeeNo { get; set; }
        public string EmployeeFullName { get; set; }
        public string Address { get; set; } 
        public string Email { get; set; }   
        public string Phone { get; set; }
    }
}
