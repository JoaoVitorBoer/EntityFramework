namespace DemoEFCoreWebApi.Models;

using Microsoft.EntityFrameworkCore;
public class LojinhaContext : DbContext
{
    public LojinhaContext()
    {
    }
    public LojinhaContext(DbContextOptions<LojinhaContext> options) //As configs do lojinhacontext vem do program.cs
    : base(options)
    {  
    }
    public DbSet<Produto> Produtos {get;set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>(entityBuilder => {
            entityBuilder.Property(e => e.Nome)
                .HasMaxLength(30);
            entityBuilder.Property(e => e.Descricao)
                .HasMaxLength(200);    
        });
    }
}