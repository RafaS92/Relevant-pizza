using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relevant_pizza.Models
{

    public enum Roles
    {

        Driver,
        Insider,
        Cashier,
        AssistanceManager,
        Manager
    }
    public class Employee
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Roles Role { get; set; }

        public string PhoneNumber { get; set; } 
        public decimal Salary { get; set; }
    }
}
