using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
 
namespace CarProject //DO NOT Change the namespace name
{
    public class Program //DO NOT Change the class name
    {
        public static void Main(string[] args)
        {
           using (var context = new CarContext())
           {
               IEnumerable<Car>cars = CarRepository.GetAllCarsWithMake(context);
               foreach(var c in cars)
               {
                   Console.WriteLine(
                       $"Car Id:{c.Id},Make:{c.Make?.Name},Model:{c.Model},Year: {c.Year}");
               }
           }//Implement the code here
        }
        public static ParameterExpression variableExpr = Expression.Variable(typeof(IEnumerable<Car>), "sampleVar");
        public static Expression GetMyExpression(CarContext context)
        {
            Expression assignExpr = Expression.Assign(variableExpr, Expression.Constant(context.Cars.Include(c => c.Make)));
            return assignExpr;
        }
    }
}
