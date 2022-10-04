namespace RegAPI_Lab2.Models
{
    public interface IEmpRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(Guid guid);
        Employee Add(Employee employee);
        Employee Update(Guid guid, Employee employee);
        Employee Delete(Guid guid);
            
    }
}
