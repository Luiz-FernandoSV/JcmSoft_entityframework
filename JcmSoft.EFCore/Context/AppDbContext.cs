
using JcmSoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JcmSoft.EFCore
{
    public class AppDbContext : DbContext
    {
        // mapeamento ORM
        // representa uma coleção de todas as entidades 
        public DbSet<Departamento> Departamentos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Provedor que será usado
            // String de conexão
            optionsBuilder.UseSqlServer(AppConfig.GetConnectionString());
        }
    }
}
