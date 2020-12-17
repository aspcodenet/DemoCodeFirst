using System;
using System.ComponentModel;

namespace DemoCodeFirst.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }

        public int Belopp { get; set; }
    }
}