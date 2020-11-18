using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;



//Gemeinsam mit Samuel Kowatschek entwickelt

namespace OrderImportQuiz
{
    class Program
    {
        static async void Main(string[] args)
        {
            if (args[0] == "import")
            {
                String[] customer = await File.ReadAllLinesAsync(args[1]);
                String[] orders = await File.ReadAllLinesAsync(args[2]);
            }
            


        }
    }
    class Customer
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal CreditLimit { get; set; }

        public List<Order> Orders { get; set; } = new();

    }

    class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName ="decimal(8,2)")]
        public decimal OrderValue { get; set; }

        public Customer? Customer { get; set; }
    }
}
