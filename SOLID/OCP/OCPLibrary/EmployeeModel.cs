using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class EmployeeModel: PersonModel
    {
        public string EmailAddress { get; set; }
        public EmployeeType EmployeeType { get; set; }

    }

        public enum EmployeeType {
        Executive = 0,
        Manager = 1,
        Employee = 2
    }
}
