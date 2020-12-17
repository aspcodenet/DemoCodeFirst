using System.Collections.Generic;

namespace DemoCodeFirst.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}