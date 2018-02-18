namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
    "dbo.Movies",
    c => new
    {
        Id = c.Int(nullable: false, identity: true),
        Name = c.String(),
        GenreId = c.Int(nullable: false),
        ReleaseDate = c.DateTime(nullable: false),
        DateAdded = c.DateTime(nullable: false),
        StockAmount = c.Int(nullable: false),
    })
    .PrimaryKey(t => t.Id);

            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropTable("dbo.Movies");
        }
    }
}
