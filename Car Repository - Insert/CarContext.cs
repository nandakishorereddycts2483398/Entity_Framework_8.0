using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
 
namespace CarProject  //DO NOT Change the namespace name
{
    public class CarContext : DbContext //DO NOT Change the class name
    {
         public DbSet<Car> Cars {get;set;} 
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             if(!optionsBuilder.IsConfigured)
             {
                 IConfiguration configuration = new  ConfigurationBuilder()
                 .AddJsonFile("appsettings.json")
                 .Build();
                 string connectionString = configuration.GetConnectionString("DefaultConnection");
                 optionsBuilder.UseSqlServer(connectionString);
             }// implement the code for configuring connection using connection string name mentioned in appsettings.json file
         }
        //Declare 'Cars' of type Dbset and add neccessary declaration code.
    }
}
