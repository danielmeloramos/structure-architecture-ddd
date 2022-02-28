using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Product.Infra.Data.Contexts
{
    /// <summary>
    /// Contexto de banco de dados do Produto
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() { }

        public ProductDbContext(DbContextOptions options) : base(options) { }

        /// <summary>
        /// Método que é executado quando o modelo de banco de dados está sendo criado pelo EF.
        /// Útil para realizar configurações
        /// </summary>
        /// <param name="modelBuilder">É o construtor de modelos do EF</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductDbContext).Assembly);

            //Configurations           

            //Schema
            modelBuilder.HasDefaultSchema("dbo");

            // Chama o OnModelCreating do EF para dar continuidade na criação do modelo
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(true);

            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = Environment.GetEnvironmentVariable("DataBaseSettings:ConnectionString");
                if (!string.IsNullOrEmpty(connectionString))
                    optionsBuilder.UseNpgsql(connectionString);
                else
                    optionsBuilder.UseNpgsql("ConnectionStringMigration");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
