using System;
using System.Collections.Generic;
using System.Linq;

namespace NightClub.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public Departament()
        {
        }
        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddEmploee(Employee employee)
        {
            Employees.Add(employee);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Employees.Sum(employee => employee.TotalSales(initial, final));
        }
    }
}
