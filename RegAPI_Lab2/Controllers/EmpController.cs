using Microsoft.AspNetCore.Mvc;
using RegAPI_Lab2.Models;

namespace RegAPI_Lab2.Controllers
{
    public class EmpController : Controller
    {
        private readonly EmpRepository _empRepo;

        public EmpController(EmpRepository empRepo)
        {
            _empRepo = empRepo;
        }

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

        [HttpDelete]
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
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
