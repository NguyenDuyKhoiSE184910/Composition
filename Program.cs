namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person customer1 = new Customer("Duy Khoi", "TpHCM", "Khoi@gmail", "0909762882", "VIP");
            Console.WriteLine(customer1.DisplayInformationToScreen());
        }
    }
}
