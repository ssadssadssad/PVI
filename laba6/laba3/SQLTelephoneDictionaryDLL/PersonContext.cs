using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace SQLTelephoneDictionaryDLL
{
    public class PersonContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Dictionary.mdf';Integrated Security=True");
        }
        public DbSet<Person> People { get; set; }
    }
}
