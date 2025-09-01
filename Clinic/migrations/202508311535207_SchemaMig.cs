namespace Clinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchemaMig : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Appointments", newSchema: "CL");
            MoveTable(name: "dbo.Patients", newSchema: "CL");
            MoveTable(name: "dbo.MedicalRecords", newSchema: "CL");
            MoveTable(name: "dbo.Users", newSchema: "CL");
            MoveTable(name: "dbo.Reports", newSchema: "CL");
        }
        
        public override void Down()
        {
            MoveTable(name: "CL.Reports", newSchema: "dbo");
            MoveTable(name: "CL.Users", newSchema: "dbo");
            MoveTable(name: "CL.MedicalRecords", newSchema: "dbo");
            MoveTable(name: "CL.Patients", newSchema: "dbo");
            MoveTable(name: "CL.Appointments", newSchema: "dbo");
        }
    }
}
