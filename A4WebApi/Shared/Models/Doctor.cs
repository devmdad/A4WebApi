using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4WebApi.Shared.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        public string Name { get; set; }

        public string Specialization { get; set; }

        public int AppointmentPrice { get; set; }

        public List<Patients> Patients { get; set; } //navigation prop


    }
}
