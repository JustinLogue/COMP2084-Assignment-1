using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Repeating {  get; set; }

        [Display(Name ="Category")]

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

    }
}
