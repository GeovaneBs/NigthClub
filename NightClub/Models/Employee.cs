using System;
using System.Collections.Generic;
using System.Linq;

namespace NightClub.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Login { get; set; }
        public string Password { get; set; }
        public Departament Departament { get; set; }
        public int DepartamentId { get; set; }
        public ICollection<Sales> Sales { get; set; } = new List<Sales>();
        public Employee()
        {
        }

        public Employee(int id, string name, int login, string password, Departament departament)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
            Departament = departament;
        }
        public void AddSales(Sales sales)
        {
            Sales.Add(sales);
        }
        public void RemoveSales(Sales sales)
        {
            Sales.Remove(sales);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sl => sl.Date >= initial && sl.Date <= final).Sum(sl => sl.Amount);
        }
    }
}
