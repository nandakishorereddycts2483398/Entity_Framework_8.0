using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace CarProject  //DO NOT Change the namespace name
{
    public class CarContext: DbContext //DO NOT Change the class name
    {
        public DbSet<Car> Cars{get; set;}
        public DbSet<Make> Makes{ get; set;}
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             // implement the code for configuring connection using connection string name mentioned in appsettings.json file
             if(!optionsBuilder.IsConfigured){
                 IConfiguration configuration= new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                 string connectionString= configuration.GetConnectionString("DefaultConnection");
                 optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
             }
         }
        //Declare 'Cars' and 'Makes' of type Dbset and add neccessary declaration code.
    }
}
