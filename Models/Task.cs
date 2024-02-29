using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Mission08_Practice.Models
{
    //create object that database will store
    public class Task
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required]
        public string TaskDescription { get; set; }

        public string DueDate { get; set; }

        [Required]
        public string Quadrant { get; set; }

        public string Category { get; set; }

        public int Completed { get; set; }
    }
}