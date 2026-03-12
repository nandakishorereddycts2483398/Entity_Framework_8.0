namespace CarProject  //DO NOT Change the namespace name
{
    public class CarRepository //DO NOT Change the class name
    {
        //Implement the code here
        public bool AddCar(Car car)
        {
            using (var context = new CarContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
            return true;
        }
    }
}
