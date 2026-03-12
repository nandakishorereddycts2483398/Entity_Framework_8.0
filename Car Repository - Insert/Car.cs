using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace CarProject 
{
    public class Car 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
 
        // Changed from int to string
        public string Brand { get; set; }
 
        // Changed from int to string
        public string Model { get; set; }
 
        // Changed from int to double
        public double Price { get; set; } 
    }
}
