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
    public class Report
    {
        [Key]
        public int ReportID { get; set; }

        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        [MaxLength(255)]
        public string Diagnosis { get; set; }

        [MaxLength(255)]
        public string Treatment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Patient> Patients { get; set; }
        
    }
}
