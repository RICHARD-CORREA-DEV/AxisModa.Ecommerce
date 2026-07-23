using Microsoft.EntityFrameworkCore;
using AxisModa.Ecommerce.Domain;

namespace AxisModa.Ecommerce.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Tabela de Produtos mapeada diretamente do Domínio
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuração fluente para garantir integridade e regras de banco
        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(p => p.Id);
            
            entity.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(p => p.Descricao)
                .HasMaxLength(500);

            entity.Property(p => p.Preco)
                .HasPrecision(18, 2)
                .IsRequired();

            entity.Property(p => p.ImagemUrl)
                .IsRequired()
                .HasMaxLength(500);

            entity.Property(p => p.Categoria)
                .IsRequired()
                .HasMaxLength(80);

            entity.Property(p => p.Subcategoria)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(p => p.DataCriacao)
                .IsRequired();

            entity.HasData(
                new
                {
                    Id = Guid.Parse("9f8c7bcf-6f68-459b-a7b8-a733370f2cb7"),
                    Nome = "Camisa Linho Comfort",
                    Descricao = "Camisa de linho respiravel com corte classico.",
                    Preco = 189.90m,
                    ImagemUrl = "/uploads/produtos/camisa.jpg",
                    Categoria = "Masculino",
                    Subcategoria = "Camisa",
                    Estoque = 25,
                    Ativo = true,
                    DataCriacao = new DateTime(2026, 7, 23, 0, 0, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("60762f4d-bc3f-4221-b306-e5f7ba2920e9"),
                    Nome = "Vestido Seda Midi",
                    Descricao = "Vestido de seda premium fluido para ocasioes especiais.",
                    Preco = 349.90m,
                    ImagemUrl = "/uploads/produtos/vestido.jpg",
                    Categoria = "Feminino",
                    Subcategoria = "Vestido",
                    Estoque = 18,
                    Ativo = true,
                    DataCriacao = new DateTime(2026, 7, 23, 0, 0, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("aeaaec9f-a407-4909-b6c9-a65f7356a263"),
                    Nome = "Conjunto Infantil Algodao",
                    Descricao = "Conjunto super confortavel de camiseta e shorts.",
                    Preco = 99.90m,
                    ImagemUrl = "/uploads/produtos/infantil.jpg",
                    Categoria = "Infantil",
                    Subcategoria = "Conjunto",
                    Estoque = 40,
                    Ativo = true,
                    DataCriacao = new DateTime(2026, 7, 23, 0, 0, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("bb98a8d4-4e0e-46db-bef6-56cc77ecf145"),
                    Nome = "Blusa Cropped Urban",
                    Descricao = "Blusa cropped de malha com toque macio.",
                    Preco = 79.90m,
                    ImagemUrl = "/uploads/produtos/blusa.jpg",
                    Categoria = "Feminino",
                    Subcategoria = "Blusa",
                    Estoque = 32,
                    Ativo = true,
                    DataCriacao = new DateTime(2026, 7, 23, 0, 0, 0, DateTimeKind.Utc)
                });
        });
    }
}
