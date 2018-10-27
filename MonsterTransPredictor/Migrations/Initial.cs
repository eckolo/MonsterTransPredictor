namespace MonsterTransPredictor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TransTerms", "Monster_id", "dbo.Monsters");
            DropIndex("dbo.TransTerms", new[] { "Monster_id" });
            AddColumn("dbo.TransTerms", "priority", c => c.Int(nullable: false));
            AlterColumn("dbo.TransTerms", "monster_id", c => c.Int(nullable: false));
            CreateIndex("dbo.TransTerms", "monster_id");
            AddForeignKey("dbo.TransTerms", "monster_id", "dbo.Monsters", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransTerms", "monster_id", "dbo.Monsters");
            DropIndex("dbo.TransTerms", new[] { "monster_id" });
            AlterColumn("dbo.TransTerms", "monster_id", c => c.Int());
            DropColumn("dbo.TransTerms", "priority");
            CreateIndex("dbo.TransTerms", "Monster_id");
            AddForeignKey("dbo.TransTerms", "Monster_id", "dbo.Monsters", "id");
        }
    }
}
