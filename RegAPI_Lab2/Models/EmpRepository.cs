namespace RegAPI_Lab2.Models
{
    public class EmpRepository : IEmpRepository
    {
        private readonly AppDbContext _empContext;

        public EmpRepository(AppDbContext empContext)
        {
            _empContext = empContext;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _empContext.employees.ToList();
        }

        public Employee GetById(int id)
        {
            var employee = _empContext.employees.FirstOrDefault(e => e.Id == id);
            
            return employee;
        }
        public Employee Add(Employee employee)
        {
            _empContext.employees.Add(employee);
            _empContext.SaveChanges();
            return employee;
        }
        public Employee Update(Employee employee)
        {
            var empToUpdate = _empContext.employees.FirstOrDefault(e => e.Id == employee.Id);
            if (empToUpdate != null)
            {
                //06102022
                //empToUpdate.FirstName = employee.FirstName;
                //empToUpdate.LastName = employee.LastName;
                //empToUpdate.Gender = employee.Gender;
                //empToUpdate.Email = employee.Email;
                //empToUpdate.PhoneNumber = employee.PhoneNumber;
                //empToUpdate.Adress = employee.Adress;
                //empToUpdate.Salary = employee.Salary;
                //empToUpdate.DepartmentId = employee.DepartmentId;

                _empContext.employees.Update(empToUpdate);
                _empContext.SaveChanges();
            }
            return empToUpdate;
        }
        public Employee Delete(int id)
        {
            var empToDelete = _empContext.employees.FirstOrDefault(emp => emp.Id == id);
            if (empToDelete != null)
            {
                _empContext.employees.Remove(empToDelete);
                _empContext.SaveChanges();
            }
            return empToDelete;
        }

        public IEnumerable<Employee> GetEmpsByDepId(int id)
        {
            var empsOfDep = _empContext.employees.Where(emp => emp.DepartmentId == id).ToList();
            return empsOfDep;
        }
    }
}
