namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandartMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandartMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandartMessages.EndApplication();
        }
    }
}