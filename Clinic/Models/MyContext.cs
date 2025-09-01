using ClinicSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("Data Source=MAHMOUD\\SQLEXPRESS;Initial Catalog=ClinicSystem;Integrated Security=True;")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // هنا بتغير الـ Schema الافتراضي
            modelBuilder.HasDefaultSchema("CL");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        
    }
}
