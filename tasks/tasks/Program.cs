
namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Fuad", 21);
            person1.ShowPersonData();

            Console.WriteLine(@"
------------------------------------------------------------------------------------------------------------------------
");

            Car car1 = new Car("Hyundai", "Sonata", 2016, 160, "Gasolina");
            car1.StartCar();

            Console.WriteLine(@"
------------------------------------------------------------------------------------------------------------------------
");

            CheckingAccount checking = new CheckingAccount(200m);
            checking.Deposit(150m);
            checking.Withdraw(200m);
            checking.Withdraw(250m);
        }
    }
}
