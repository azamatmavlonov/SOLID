using LSPDemoLibrary;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Ali";
            accountingVP.LastName = "Ganiev";
            accountingVP.CalculatePerHourRate(4);

            IManaged employee = new Manager();

            employee.FirstName = "Abdu";
            employee.LastName = "Nurov";
            employee.AssignManager(accountingVP);
            employee.CalculatePerHourRate(2);

            Console.WriteLine($"{ employee.FirstName }'s salary is ${ employee.Salary }/hour.");

            Console.ReadLine();
        }
    }
}