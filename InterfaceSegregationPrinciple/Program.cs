using DemoLibrary.DVD;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();

            Console.ReadLine();
        }
    }
}