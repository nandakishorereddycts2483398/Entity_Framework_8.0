using System;
 
namespace CarProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter car id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter car brand");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter car model");
            string model = Console.ReadLine();
            Console.WriteLine("Enter car price");
            double price = Convert.ToDouble(Console.ReadLine());
            var car = new Car
            {
                Id = id,
                Brand = brand,
                Model = model,
                Price = price
            };
 
            var repo = new CarRepository();
            bool ok = repo.AddCar(car);
 
            if (ok)
            {
                Console.WriteLine("Details Added Successfully");
            }
        }
    }
}
