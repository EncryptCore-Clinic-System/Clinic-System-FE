namespace Clinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
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
                .ForeignKey("dbo.Patients", t => t.Patient_PatientID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.PatientID)
                .Index(t => t.UserID)
                .Index(t => t.Patient_PatientID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Patients",
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
                        Appointment_AppointmentID = c.Int(),
                        Report_ReportID = c.Int(),
                    })
                .PrimaryKey(t => t.PatientID)
                .ForeignKey("dbo.Appointments", t => t.Appointment_AppointmentID)
                .ForeignKey("dbo.Reports", t => t.Report_ReportID)
                .Index(t => t.Appointment_AppointmentID)
                .Index(t => t.Report_ReportID);
            
            CreateTable(
                "dbo.MedicalRecords",
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
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.PatientID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
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
                .ForeignKey("dbo.Appointments", t => t.Appointment_AppointmentID)
                .Index(t => t.Appointment_AppointmentID);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        Diagnosis = c.String(maxLength: 255),
                        Treatment = c.String(maxLength: 255),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReportID)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "Report_ReportID", "dbo.Reports");
            DropForeignKey("dbo.Reports", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.Users", "Appointment_AppointmentID", "dbo.Appointments");
            DropForeignKey("dbo.Appointments", "UserID", "dbo.Users");
            DropForeignKey("dbo.Patients", "Appointment_AppointmentID", "dbo.Appointments");
            DropForeignKey("dbo.Appointments", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.MedicalRecords", "UserID", "dbo.Users");
            DropForeignKey("dbo.Appointments", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.MedicalRecords", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "Patient_PatientID", "dbo.Patients");
            DropIndex("dbo.Reports", new[] { "PatientID" });
            DropIndex("dbo.Users", new[] { "Appointment_AppointmentID" });
            DropIndex("dbo.MedicalRecords", new[] { "UserID" });
            DropIndex("dbo.MedicalRecords", new[] { "PatientID" });
            DropIndex("dbo.Patients", new[] { "Report_ReportID" });
            DropIndex("dbo.Patients", new[] { "Appointment_AppointmentID" });
            DropIndex("dbo.Appointments", new[] { "User_UserID" });
            DropIndex("dbo.Appointments", new[] { "Patient_PatientID" });
            DropIndex("dbo.Appointments", new[] { "UserID" });
            DropIndex("dbo.Appointments", new[] { "PatientID" });
            DropTable("dbo.Reports");
            DropTable("dbo.Users");
            DropTable("dbo.MedicalRecords");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
