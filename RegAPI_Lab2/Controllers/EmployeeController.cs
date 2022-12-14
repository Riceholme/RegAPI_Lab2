using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegAPI_Lab2.Models;

namespace RegAPI_Lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpRepository _empRepo;

        public EmployeeController(IEmpRepository empRepo)
        {
            _empRepo = empRepo;
        }
        //private readonly EmpRepository _empRepo;
        //public EmployeeController(EmpRepository empRepo)
        //{
        //    _empRepo = empRepo;
        //}

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmps = _empRepo.GetAll().ToList();
            if (allEmps != null)
            {
                return Ok(allEmps);
            }
            return NotFound("No employees was found");
        }
        [Route("employee/{id}")]
        [HttpGet]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _empRepo.GetById(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Employee with {id} was not found");
        }
        [Route("employeesofdeparment/{id}")]
        [HttpGet]
        public IActionResult GetEmpsByDepartId(int id)
        {
            var empsOfDep = _empRepo.GetEmpsByDepId(id);
            if (empsOfDep != null)
            {
                return Ok(empsOfDep);
            }
            return NotFound("No employees found of that Department");
        }
        [Route("economyemployees")]
        [HttpGet]
        public IActionResult GetEconomyEmps()
        {
            var empsOfDep = _empRepo.GetAll().Where(x => x.DepartmentId == 1);
            if (empsOfDep != null)
            {
                return Ok(empsOfDep);
            }
            return NotFound("No employees found of that Department");
        }
        [Route("itemployees")]
        [HttpGet]
        public IActionResult GetItEmps()
        {
            var empsOfDep = _empRepo.GetAll().Where(x => x.DepartmentId == 2);
            if (empsOfDep != null)
            {
                return Ok(empsOfDep);
            }
            return NotFound("No employees found of that Department");
        }
        [Route("marketingemployees")]
        [HttpGet]
        public IActionResult GetMarketingEmps()
        {
            var empsOfDep = _empRepo.GetAll().Where(x => x.DepartmentId == 3);
            if (empsOfDep != null)
            {
                return Ok(empsOfDep);
            }
            return NotFound("No employees found of that Department");
        }
        [Route("salesemployees")]
        [HttpGet]
        public IActionResult GetSalesEmps()
        {
            var empsOfDep = _empRepo.GetAll().Where(x => x.DepartmentId == 4);
            if (empsOfDep != null)
            {
                return Ok(empsOfDep);
            }
            return NotFound("No employees found of that Department");
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _empRepo.Add(employee);
                return Ok(employee);
            }
            return NotFound("Could not add employee");
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee emp)
        {
            if (emp != null)
            {
                _empRepo.Update(emp);
                return Ok(emp);
            }
            return NotFound("Employee not found to update");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var empToDelete = _empRepo.GetById(id);
            if (empToDelete != null)
            {
                _empRepo.Delete(id);
                return Ok(empToDelete);
            }
            return NotFound($"Employee with {id} could not be deleted");
        }
    }
}
