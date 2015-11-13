namespace Ejercicio1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deps : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Empleadoes", "Departamentos_id", c => c.Int());
            CreateIndex("dbo.Empleadoes", "Departamentos_id");
            AddForeignKey("dbo.Empleadoes", "Departamentos_id", "dbo.Departamentos", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleadoes", "Departamentos_id", "dbo.Departamentos");
            DropIndex("dbo.Empleadoes", new[] { "Departamentos_id" });
            DropColumn("dbo.Empleadoes", "Departamentos_id");
            DropTable("dbo.Departamentos");
        }
    }
}
