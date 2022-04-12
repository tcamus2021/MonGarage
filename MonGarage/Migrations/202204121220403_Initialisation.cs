namespace MonGarage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialisation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        IdClient = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        Numero = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdClient);
            
            CreateTable(
                "dbo.Fiches",
                c => new
                    {
                        IdFiche = c.Int(nullable: false, identity: true),
                        Prix = c.Double(nullable: false),
                        Client_IdClient = c.Int(nullable: false),
                        Voiture_IdVoiture = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdFiche)
                .ForeignKey("dbo.Clients", t => t.Client_IdClient, cascadeDelete: true)
                .ForeignKey("dbo.Voitures", t => t.Voiture_IdVoiture, cascadeDelete: true)
                .Index(t => t.Client_IdClient)
                .Index(t => t.Voiture_IdVoiture);
            
            CreateTable(
                "dbo.Voitures",
                c => new
                    {
                        IdVoiture = c.Int(nullable: false, identity: true),
                        Model = c.String(nullable: false),
                        Marque_Sigle = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.IdVoiture)
                .ForeignKey("dbo.Marques", t => t.Marque_Sigle, cascadeDelete: true)
                .Index(t => t.Marque_Sigle);
            
            CreateTable(
                "dbo.Marques",
                c => new
                    {
                        Sigle = c.String(nullable: false, maxLength: 128),
                        NomComplet = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Sigle);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fiches", "Voiture_IdVoiture", "dbo.Voitures");
            DropForeignKey("dbo.Voitures", "Marque_Sigle", "dbo.Marques");
            DropForeignKey("dbo.Fiches", "Client_IdClient", "dbo.Clients");
            DropIndex("dbo.Voitures", new[] { "Marque_Sigle" });
            DropIndex("dbo.Fiches", new[] { "Voiture_IdVoiture" });
            DropIndex("dbo.Fiches", new[] { "Client_IdClient" });
            DropTable("dbo.Marques");
            DropTable("dbo.Voitures");
            DropTable("dbo.Fiches");
            DropTable("dbo.Clients");
        }
    }
}
