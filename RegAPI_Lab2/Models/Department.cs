﻿namespace RegAPI_Lab2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> EmpsOfDep { get; set; }

    }
}