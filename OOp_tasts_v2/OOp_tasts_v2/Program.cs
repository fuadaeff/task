namespace OOp_tasts_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tempConverter temp1 = new tempConverter(50);
            temp1.GetTemp();


            productClass product1 = new productClass("Phone", 600, 1500);
            product1.GetInfo();


            calcSalary emp1 = new calcSalary("Elsad", 15, 8);
            emp1.Calculate();

            Car car1 = new Car();
            car1.StartEngine();
            car1.StopEngine();
        }
    }
}
