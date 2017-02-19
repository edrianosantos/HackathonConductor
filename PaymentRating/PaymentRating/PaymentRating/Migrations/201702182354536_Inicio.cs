namespace PaymentRating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avaliacoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdMeioPagamento = c.Int(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Nota = c.Int(nullable: false),
                        Comentario = c.String(nullable: false, maxLength: 300),
                        Sugestao = c.String(maxLength: 300),
                        Recomendar = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MeiosPagamentos", t => t.IdMeioPagamento)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario)
                .Index(t => t.IdMeioPagamento)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.MeiosPagamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 100),
                        Senha = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avaliacoes", "IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Avaliacoes", "IdMeioPagamento", "dbo.MeiosPagamentos");
            DropIndex("dbo.Avaliacoes", new[] { "IdUsuario" });
            DropIndex("dbo.Avaliacoes", new[] { "IdMeioPagamento" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.MeiosPagamentos");
            DropTable("dbo.Avaliacoes");
        }
    }
}
