using Microsoft.EntityFrameworkCore;
using Relevant_pizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relevant_pizza.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
