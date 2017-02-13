namespace GYM.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.heroes",
                c => new
                    {
                        heroId = c.Guid(nullable: false),
                        name = c.String(nullable: false, maxLength: 20, unicode: false),
                        createdOn = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.heroId)
                .Index(t => t.name, unique: true);
            
            CreateTable(
                "dbo.itens",
                c => new
                    {
                        itemId = c.Guid(nullable: false),
                        name = c.String(nullable: false, maxLength: 20, unicode: false),
                        Hero_heroId = c.Guid(),
                    })
                .PrimaryKey(t => t.itemId)
                .ForeignKey("dbo.heroes", t => t.Hero_heroId)
                .Index(t => t.Hero_heroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.itens", "Hero_heroId", "dbo.heroes");
            DropIndex("dbo.itens", new[] { "Hero_heroId" });
            DropIndex("dbo.heroes", new[] { "name" });
            DropTable("dbo.itens");
            DropTable("dbo.heroes");
        }
    }
}
