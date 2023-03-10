namespace Filmography.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Sex = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        City = c.String(),
                        FinState = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountryMovies", t => t.Nation_Id)
                .Index(t => t.Nation_Id);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.DateTime(nullable: false),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BoxOffice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Viewers = c.Long(nullable: false),
                        Rating = c.Single(nullable: false),
                        CountryProduce_Id = c.Int(),
                        FilmProduser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountryMovies", t => t.CountryProduce_Id)
                .ForeignKey("dbo.Produsers", t => t.FilmProduser_Id)
                .Index(t => t.CountryProduce_Id)
                .Index(t => t.FilmProduser_Id);
            
            CreateTable(
                "dbo.DemoCountries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CountryMovies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Sex = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        City = c.String(),
                        FinState = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountryMovies", t => t.Nation_Id)
                .Index(t => t.Nation_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FilmActors",
                c => new
                    {
                        Film_Id = c.Int(nullable: false),
                        Actor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Film_Id, t.Actor_Id })
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_Id, cascadeDelete: true)
                .Index(t => t.Film_Id)
                .Index(t => t.Actor_Id);
            
            CreateTable(
                "dbo.DemoCountryFilms",
                c => new
                    {
                        DemoCountry_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DemoCountry_Id, t.Film_Id })
                .ForeignKey("dbo.DemoCountries", t => t.DemoCountry_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.DemoCountry_Id)
                .Index(t => t.Film_Id);
            
            CreateTable(
                "dbo.GenreFilms",
                c => new
                    {
                        Genre_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Film_Id })
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Film_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GenreFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.GenreFilms", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Produsers", "Nation_Id", "dbo.CountryMovies");
            DropForeignKey("dbo.Films", "FilmProduser_Id", "dbo.Produsers");
            DropForeignKey("dbo.Films", "CountryProduce_Id", "dbo.CountryMovies");
            DropForeignKey("dbo.Actors", "Nation_Id", "dbo.CountryMovies");
            DropForeignKey("dbo.DemoCountryFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.DemoCountryFilms", "DemoCountry_Id", "dbo.DemoCountries");
            DropForeignKey("dbo.FilmActors", "Actor_Id", "dbo.Actors");
            DropForeignKey("dbo.FilmActors", "Film_Id", "dbo.Films");
            DropIndex("dbo.GenreFilms", new[] { "Film_Id" });
            DropIndex("dbo.GenreFilms", new[] { "Genre_Id" });
            DropIndex("dbo.DemoCountryFilms", new[] { "Film_Id" });
            DropIndex("dbo.DemoCountryFilms", new[] { "DemoCountry_Id" });
            DropIndex("dbo.FilmActors", new[] { "Actor_Id" });
            DropIndex("dbo.FilmActors", new[] { "Film_Id" });
            DropIndex("dbo.Produsers", new[] { "Nation_Id" });
            DropIndex("dbo.Films", new[] { "FilmProduser_Id" });
            DropIndex("dbo.Films", new[] { "CountryProduce_Id" });
            DropIndex("dbo.Actors", new[] { "Nation_Id" });
            DropTable("dbo.GenreFilms");
            DropTable("dbo.DemoCountryFilms");
            DropTable("dbo.FilmActors");
            DropTable("dbo.Users");
            DropTable("dbo.Genres");
            DropTable("dbo.Produsers");
            DropTable("dbo.CountryMovies");
            DropTable("dbo.DemoCountries");
            DropTable("dbo.Films");
            DropTable("dbo.Actors");
        }
    }
}
