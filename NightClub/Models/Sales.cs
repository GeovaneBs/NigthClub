using System;

using NightClub.Models.Enums;

namespace NightClub.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Employee Employee { get; set; }

        public Sales()
        {

        }
        public Sales(int id, DateTime date, double amount, SaleStatus status, Employee employee)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Employee = employee;
        }
    }
}
