using JcmSoft.Domain.Entities;
using JcmSoft.Domain.Enums;
using JcmSoft.EFCore.Funcoes;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace JcmSoft.EFCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioDetalhe> FuncionarioDetalhes { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<FuncionariosProjetos> FuncionariosProjetos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<FuncionarioDepartamentoView> FuncionariosDepartamentosViews { get; set; }

        public IQueryable<Projeto> ProjetosAtivosApos(DateTime dataInicio) => FromExpression(() => ProjetosAtivosApos(dataInicio));
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppConfig.GetConnectionString());

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.HasDbFunction(() => FuncoesSql.CalcularAnosDeServico(default)).HasName("CalcularAnosDeServico").HasSchema("dbo");

            modelBuilder
                .HasDbFunction(typeof(AppDbContext)
                .GetMethod(nameof(ProjetosAtivosApos), new[] { typeof(DateTime) })!)
                .HasName("ProjetosAtivosApos").HasSchema("dbo");

            modelBuilder.HasSequence<int>("NumeroOSSequence")
                        .StartsAt(2001)
                        .IncrementsBy(10) 
                        .HasMin(2001) // opcional valor minimo
                        .HasMax(999999) // opcional valor maximo
                        .IsCyclic(); // opcional: reinicia ao atingir o limite (o padrao é nao usar)

            modelBuilder.Entity<Projeto>().Property(p => p.NumeroOrdemServico).HasDefaultValueSql("NEXT VALUE FOR NumeroOSSequence");
        }

    }
}