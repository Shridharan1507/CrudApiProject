using CrudApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Data
{
    public class EmpContext : DbContext
    {

        public EmpContext(DbContextOptions<EmpContext>options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
