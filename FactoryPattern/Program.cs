namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want a [2]motorcyle or a [4]car");
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input) || input != 2 && input != 4)
            {
                Console.WriteLine("Please input 2 or 4");
            }

            IVehicle vehicle = VehicleFactory.GetVehicle(input);
            vehicle.Drive();
        }
    }
}
