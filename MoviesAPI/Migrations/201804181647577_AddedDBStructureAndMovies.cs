namespace MoviesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDBStructureAndMovies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        YearReleased = c.Int(nullable: false),
                        Genre = c.String(),
                        Tagline = c.String(),
                        Rating = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
