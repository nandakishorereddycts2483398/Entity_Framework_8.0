using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace CarProject //DO NOT Change the namespace name
{
    public class Make //DO NOT Change the class name
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
       public int Id{get;set;}
       public string Name{get;set;}
       public ICollection<Car>Cars {get;set;}//Implement the code here
    }
}
 
