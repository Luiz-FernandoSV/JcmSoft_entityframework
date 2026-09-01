using JcmSoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.EFCore.Configurations
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> entity)
        {
            entity.HasMany(d => d.Funcionarios)
                  .WithOne(f => f.Departamento)
                  .HasForeignKey(f => f.DepartamentoId)
                   .OnDelete(DeleteBehavior.Restrict);

            entity.Property(d => d.Nome).IsRequired().HasMaxLength(100);
            entity.Property(d => d.Descricao).IsRequired().HasMaxLength(200);

            entity.Property(d => d.RowVersion).IsRowVersion();

            entity.HasData(
                new Departamento
                {
                    DepartamentoId = 1,
                    Nome = "Desenvolvimento",
                    Descricao = "Desenvolvimento de sistemas e aplicações"
                },

                new Departamento
                {
                    DepartamentoId = 2,
                    Nome = "Pesquisa",
                    Descricao = "Pesquisa, análise e inovação de produtos"
                },

                new Departamento
                {
                    DepartamentoId = 3,
                    Nome = "Financeiro",
                    Descricao = "Gestão financeira e contábil da empresa"
                }
            );
        }
    }
}
