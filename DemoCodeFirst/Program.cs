using System;
using System.Linq;
using DemoCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                context.Database.Migrate();
            }


            using (var context = new MyContext())
            {
                context.Accounts.Add( new UserAccount
                {
                    Age = 12,
                    Password = "hejsan123",
                    UserName = "kalle123"
                } );
                context.SaveChanges();


                var account = context.Accounts.FirstOrDefault(p => p.UserName == "kalle123");
                account.Invoices.Add(new Invoice { Belopp=12,Datum = DateTime.Now});
                account.Invoices.Add(new Invoice { Belopp = 13, Datum = new DateTime(2020,12,24) });
                context.SaveChanges();

            }


            Console.WriteLine("Hello World!");
        }
    }
}
