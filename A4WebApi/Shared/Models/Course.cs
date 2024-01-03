using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4WebApi.Shared.Models
{
    public class Course
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public int Marks { get; set; }

        public List<Student> Students { get; set; } //navigation prop
    }
}
