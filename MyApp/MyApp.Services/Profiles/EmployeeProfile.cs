using AutoMapper;
using MyApp.Models;
using MyApp.Services.CustomDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services.Profiles
{
    public  class EmployeeProfile : Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<Employees, EmployeeDTO>().ForMember(dest => dest.EmployeeFullName, 
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            CreateMap<CreateEmployeeDTO, Employees>();
            CreateMap<UpdateEmployeeDTO, Employees>();
        }    
    }
}
