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

        [HttpGet("{empNo}", Name = "GetEmployees")]
        public IActionResult GetEmployees(int empNo)
        {
            var Employees = _service.GetEmployee(empNo);
            var mappedEmployees = _mapper.Map<EmployeeDTO>(Employees);
            return Ok(mappedEmployees);
        }

        [HttpPost]
        public ActionResult<CreateEmployeeDTO> PostEmployee(CreateEmployeeDTO employee)
        {
            var newEmployee = _mapper.Map<Employees>(employee);
            var saveEmployee = _service.CreateEmployee(newEmployee);
            var authForSave = _mapper.Map<EmployeeDTO>(saveEmployee);

            return CreatedAtRoute("GetEmployees", new { empNo = authForSave.EmployeeNo }, authForSave);
        }

        [HttpPut("{empNo}")]
        public ActionResult UpdateEmployee(int empNo, UpdateEmployeeDTO update)
        {
            var updateEmp = _service.GetEmployee(empNo);
            if (updateEmp is null)
            {
                return NoContent();
            }

            _mapper.Map(update, updateEmp);
            _service.UpdateEmployee(updateEmp);

            return NoContent();
        }

        [HttpDelete("{empNo}")]
        public ActionResult DeleteEmployee(int empNo)
        {
            var deleteEmp = _service.GetEmployee(empNo);
            if (deleteEmp is null)
            {
                return NotFound();
            }

            _service.DeleteEmployee(deleteEmp);
            return NoContent();
        }
    }
}
