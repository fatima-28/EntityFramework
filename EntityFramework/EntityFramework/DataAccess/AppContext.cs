using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TodaysTask.Models;

namespace TodaysTask.DataAcsess
{
    public class AppContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4EOUDP3;Database=Employees;Integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
