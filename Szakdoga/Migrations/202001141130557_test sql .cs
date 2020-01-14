namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testsql : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sports(Nev,Sportag) VALUES ('Kosar','Labdasport')");
            Sql("INSERT INTO SportHirdetes(SportoloLetszam,Leiras,SportId,Korosztaly,UserId) VALUES (2,'anyad',1,'12-13','e84c4d64-97be-45a3-8781-d72cc77677d9')");
        }
        
        public override void Down()
        {
        }
    }
}
