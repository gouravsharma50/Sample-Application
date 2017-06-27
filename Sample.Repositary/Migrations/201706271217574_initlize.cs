namespace Sample.Repositary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initlize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ModelBases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreateDate = c.DateTime(nullable: false),
                        Status = c.Int(),
                        CreateUserId = c.Int(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateUserId = c.Int(),
                        Text = c.String(),
                        UserId = c.Int(),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        Role = c.String(maxLength: 255),
                        Company = c.String(maxLength: 255),
                        PhoneNumber = c.String(maxLength: 13),
                        BirthDate = c.DateTime(),
                        Profile = c.Int(),
                        Text1 = c.String(),
                        Title = c.String(),
                        ExternalContent = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Person_Id = c.Int(),
                        Author_Id = c.Int(),
                        PersonFrom_Id = c.Int(),
                        PersonTo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ModelBases", t => t.Person_Id)
                .ForeignKey("dbo.ModelBases", t => t.Author_Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.ModelBases", t => t.PersonFrom_Id)
                .ForeignKey("dbo.ModelBases", t => t.PersonTo_Id)
                .Index(t => t.UserId)
                .Index(t => t.Person_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.PersonFrom_Id)
                .Index(t => t.PersonTo_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Role = c.String(),
                        Company = c.String(),
                        PhoneNumber = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ModelBases", "PersonTo_Id", "dbo.ModelBases");
            DropForeignKey("dbo.ModelBases", "PersonFrom_Id", "dbo.ModelBases");
            DropForeignKey("dbo.ModelBases", "UserId", "dbo.Users");
            DropForeignKey("dbo.ModelBases", "Author_Id", "dbo.ModelBases");
            DropForeignKey("dbo.ModelBases", "Person_Id", "dbo.ModelBases");
            DropIndex("dbo.ModelBases", new[] { "PersonTo_Id" });
            DropIndex("dbo.ModelBases", new[] { "PersonFrom_Id" });
            DropIndex("dbo.ModelBases", new[] { "Author_Id" });
            DropIndex("dbo.ModelBases", new[] { "Person_Id" });
            DropIndex("dbo.ModelBases", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.ModelBases");
        }
    }
}
