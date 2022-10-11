using System;
using System.Collections.Generic;
using OCPLibrary;

namespace OCP {
    internal class Program {
        static void Main(string[] args) {

            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new PersonModel { FirstName = "Sue", LastName = "Storm" },
                new PersonModel { FirstName = "Nancy", LastName = "Roman" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            int i = 0;
            foreach (var person in applicants) {
                employees.Add(accountProcessor.Create(person, i));
                i++;
            }

            foreach (var emp in employees) {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } , Employee Type: { emp.GetType() }");
            }

            Console.ReadLine();
        }
    }
}
