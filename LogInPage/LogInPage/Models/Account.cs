using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LogInPage.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
    public class AccountDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
