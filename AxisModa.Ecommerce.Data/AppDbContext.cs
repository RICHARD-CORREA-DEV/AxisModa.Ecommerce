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

            entity.Property(p => p.DataCriacao)
                .IsRequired();
        });
    }
}
