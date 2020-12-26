using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace NightClub.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }
        public Product(int id, int code, string name, DateTime dueDate, double price)
        {
            Id = id;
            Code = code;
            Name = name;
            DueDate = dueDate;
            Price = price;
        }
    }
}
