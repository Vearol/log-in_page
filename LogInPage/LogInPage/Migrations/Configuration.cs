namespace LogInPage.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LogInPage.Models.AccountDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LogInPage.Models.AccountDbContext context)
        {
            context.Accounts.AddOrUpdate(i => i.ID,
          new Account
          {
              Email = "a@a",
              Name = "JohnSmith0",
              Comment = "Hi",
              Date = DateTime.Parse("2016-10-23")
          },
          new Account
          {
              Email = "b@a",
              Name = "JohnSnow",
              Comment = "fdhgkjfdhg",
              Date = DateTime.Parse("2016-10-23")
          }
         );
        }
    }
}
