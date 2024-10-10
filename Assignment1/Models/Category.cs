using System.ComponentModel.DataAnnotations;
namespace Assignment1.Models
{
    public class Category
    {
        public int CategoryId {  get; set; }
        public string Name { get; set; }

        public List<Task>? Tasks { get; set; }
        
    }
}
