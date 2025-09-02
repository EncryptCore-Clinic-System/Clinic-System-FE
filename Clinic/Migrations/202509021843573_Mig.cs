namespace Clinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CL.Appointments",
                c => new
                    {
                        AppointmentID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Diagnosis = c.String(maxLength: 255),
                        Prescription = c.String(maxLength: 255),
                        VisitDate = c.DateTime(nullable: false),
                        Patient_PatientID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentID)
                .ForeignKey("CL.Patients", t => t.Patient_PatientID)
                .ForeignKey("CL.Users", t => t.User_UserID)
                .ForeignKey("CL.Patients", t => t.PatientID, cascadeDelete: true)
                .ForeignKey("CL.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.PatientID)
                .Index(t => t.UserID)
                .Index(t => t.Patient_PatientID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "CL.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Age = c.Int(nullable: false),
                        Gender = c.String(maxLength: 10),
                        VisitType = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 20),
                        Address = c.String(maxLength: 255),
                        MedicalHistory = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        Status = c.String(),
                        Appointment_AppointmentID = c.Int(),
                        Report_ReportID = c.Int(),
                    })
                .PrimaryKey(t => t.PatientID)
                .ForeignKey("CL.Appointments", t => t.Appointment_AppointmentID)
                .ForeignKey("CL.Reports", t => t.Report_ReportID)
                .Index(t => t.Appointment_AppointmentID)
                .Index(t => t.Report_ReportID);
            
            CreateTable(
                "CL.MedicalRecords",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Diagnosis = c.String(maxLength: 255),
                        Prescription = c.String(maxLength: 255),
                        VisitDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("CL.Patients", t => t.PatientID, cascadeDelete: true)
                .ForeignKey("CL.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.PatientID)
                .Index(t => t.UserID);
            
            CreateTable(
                "CL.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 255),
                        Email = c.String(maxLength: 150),
                        Role = c.String(nullable: false, maxLength: 50),
                        Appointment_AppointmentID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("CL.Appointments", t => t.Appointment_AppointmentID)
                .Index(t => t.Appointment_AppointmentID);
            
            CreateTable(
                "CL.Reports",
                c => new
                    {
                        ReportID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        Diagnosis = c.String(maxLength: 255),
                        Treatment = c.String(maxLength: 255),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReportID)
                .ForeignKey("CL.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("CL.Patients", "Report_ReportID", "CL.Reports");
            DropForeignKey("CL.Reports", "PatientID", "CL.Patients");
            DropForeignKey("CL.Users", "Appointment_AppointmentID", "CL.Appointments");
            DropForeignKey("CL.Appointments", "UserID", "CL.Users");
            DropForeignKey("CL.Patients", "Appointment_AppointmentID", "CL.Appointments");
            DropForeignKey("CL.Appointments", "PatientID", "CL.Patients");
            DropForeignKey("CL.MedicalRecords", "UserID", "CL.Users");
            DropForeignKey("CL.Appointments", "User_UserID", "CL.Users");
            DropForeignKey("CL.MedicalRecords", "PatientID", "CL.Patients");
            DropForeignKey("CL.Appointments", "Patient_PatientID", "CL.Patients");
            DropIndex("CL.Reports", new[] { "PatientID" });
            DropIndex("CL.Users", new[] { "Appointment_AppointmentID" });
            DropIndex("CL.MedicalRecords", new[] { "UserID" });
            DropIndex("CL.MedicalRecords", new[] { "PatientID" });
            DropIndex("CL.Patients", new[] { "Report_ReportID" });
            DropIndex("CL.Patients", new[] { "Appointment_AppointmentID" });
            DropIndex("CL.Appointments", new[] { "User_UserID" });
            DropIndex("CL.Appointments", new[] { "Patient_PatientID" });
            DropIndex("CL.Appointments", new[] { "UserID" });
            DropIndex("CL.Appointments", new[] { "PatientID" });
            DropTable("CL.Reports");
            DropTable("CL.Users");
            DropTable("CL.MedicalRecords");
            DropTable("CL.Patients");
            DropTable("CL.Appointments");
        }
    }
}
