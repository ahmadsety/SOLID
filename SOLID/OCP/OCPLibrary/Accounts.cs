using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person, int reandomIndex)
        {
            EmployeeType type = (EmployeeType) (reandomIndex % 3);
            EmployeeModel output = GetEmployee(type);

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acme.com";
            output.EmployeeType = type;
            
            return output;
        }

        private EmployeeModel GetEmployee(EmployeeType employeeType)
        {
            switch (employeeType)
            {
                case EmployeeType.Employee:
                    return new EmployeeModel();
                case EmployeeType.Executive:
                    return new Executive();
                case EmployeeType.Manager:
                    return new Manager();
                default:
                    return new EmployeeModel();

            }
        }
    }
}
