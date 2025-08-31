using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using ClinicSystem.Models;


namespace ClinicSystem.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }

        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; } // Doctor is a User with Role = "Doctor"

        [MaxLength(255)]
        public string Diagnosis { get; set; }

        [MaxLength(255)]
        public string Prescription { get; set; }

        public DateTime VisitDate { get; set; } = DateTime.Now;

        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
