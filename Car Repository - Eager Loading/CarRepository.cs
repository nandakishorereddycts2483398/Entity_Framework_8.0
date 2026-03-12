using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
 
namespace CarProject  //DO NOT Change the namespace name
{
    public class CarRepository //DO NOT Change the class name
    {
        public static IEnumerable<Car> GetAllCarsWithMake(CarContext context)
        {
            return context.Cars
            .Include(c => c.Make)
            .OrderBy(c => c.Id)
            .ToList();
        }//Implement the code here
    }
}
 
