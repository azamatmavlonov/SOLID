using OCPLibrary;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Abubakr", LastName = "Mavlonov"},
                new ManagerModel { FirstName = "Mukhriddin", LastName = "Uzokov"},
                new ExecutiveModel { FirstName = "Abdu", LastName = "Ganiev"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{ employee.FirstName } { employee.LastName }: { employee.EmailAddress } IsManager: { employee.IsManager } IsExecutive: { employee.IsExecutive }");
            }

            Console.ReadLine(); 
        }
    }
}