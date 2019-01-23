using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    // BusinessEmployee Class inheriting from Employee Class
    class BusinessEmployee : Employee
    {
        // Creates double variable called "bonusBudget" and assigns value to 1000
        public double bonusBudget = 1000;

        // Calls upon base-class (Employee) constructor from within dreived class (BusinessEmployee)
        // Sets baseSalary to 50000 for all BusinessEmployee objects
        public BusinessEmployee(String name) : base(name, 50000)
        {

        }

        // This method returns the toString() method - which is the employee's ID number and name, and prints the bonus budget
        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
