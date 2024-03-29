﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace Mission_8.Models
{
    //create object that database will store
    public class Activity
    {
        [Key]
        [Required]
        public int ActivityId { get; set; }

        [Required(ErrorMessage = "Please enter the task description")]
        public string? ActivityDescription { get; set; }
        
        public string? DueDate { get; set; }

        [Required(ErrorMessage = "Please select the quadrant")]
        [Range(1,4)]
        public int Quadrant { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public int? Completed { get; set; }
    }
}