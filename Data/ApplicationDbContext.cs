using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Student> Student { get; set; } = default!;
    }
}