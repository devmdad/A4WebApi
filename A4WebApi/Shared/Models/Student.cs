using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4WebApi.Shared.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        // Foreign key for the one-to-many relationship
        public int CourseId { get; set; }

        // Navigation property to represent the parent doctor
        //public Course Course { get; set; }
    }
}
