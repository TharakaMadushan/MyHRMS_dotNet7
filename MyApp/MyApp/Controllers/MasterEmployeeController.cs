using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using MyApp.Services.CustomDTO;
using MyApp.Services.MasterEmployee;

namespace MyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterEmployeeController : ControllerBase
    {
        private readonly IMasterEmployee _service;
        private readonly IMapper _mapper;

        public MasterEmployeeController(IMasterEmployee service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<EmployeeDTO>> GetEmployees()
        {
            var employees = _service.GetAllEmployees();
            var mappedEmployees = _mapper.Map<ICollection<EmployeeDTO>>(employees);
            return Ok(mappedEmployees);
        }

        //[HttpGet]
        //public IActionResult GetEmployees()
        //{
        //    var Employees = _service.GetAllEmployees(); 
        //    var mappedEmployees = _mapper.Map<Employees>(Employees);
        //    return Ok(mappedEmployees);
        //}
    }
}
