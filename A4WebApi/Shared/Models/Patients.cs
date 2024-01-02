using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4WebApi.Shared.Models
{
    public class Patients
    {
        [Key]
        public int PatientId { get; set; }

        public string PatientName { get; set;}

        public string PatientDescription { get; set;}

        // Foreign key for the one-to-many relationship
        public int DoctorId { get; set; }

        // Navigation property to represent the parent doctor
        public Doctor Doctor { get; set; }

    }
}
