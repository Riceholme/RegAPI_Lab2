namespace RegAPI_Lab2.Models
{
    public interface IEmpRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        Employee Delete(int id);
        IEnumerable<Employee> GetEmpsByDepId(int id);
    }
}
