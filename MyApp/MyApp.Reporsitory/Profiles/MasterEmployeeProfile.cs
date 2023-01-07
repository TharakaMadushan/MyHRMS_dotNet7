using AutoMapper;
using MyApp.Models;
using MyApp.Reporsitory.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Reporsitory.Profiles
{
    public class MasterEmployeeProfile : Profile
    {
        public MasterEmployeeProfile() 
        {
            CreateMap<MasterEmployee, MasterEmployeeDTO>().ForMember(dest => dest.Address,
                opt => opt.MapFrom(src => $"{src.Address1}, {src.Address2}, {src.Address3}, {src.Address4}"));

            CreateMap<MasterEmployee, MasterEmployeeDTO>().ForMember(dest => dest.EmployeeFullName,
                opt => opt.MapFrom(src => $"{src.FirstName}, {src.LastName}"));

            //CreateMap<CreateAuthorDTO, Author>();

        }
    }
}
