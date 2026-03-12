using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace CarProject //DO NOT Change the namespace name
{
    public class Car //DO NOT Change the class name
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
       public int Id {get;set;}
       public string Model {get;set;}
       public int Year {get;set;}
       public int MakeId {get;set;}
       public  Make Make {get;set;}//Implement the code here
    }
}
