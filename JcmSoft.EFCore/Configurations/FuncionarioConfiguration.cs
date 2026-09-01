using JcmSoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.EFCore.Configurations
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> entity)
        {
            entity.HasOne(f => f.Departamento)
                  .WithMany(d => d.Funcionarios)
                  .HasForeignKey(f => f.DepartamentoId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(f => f.FuncionarioDetalhe)
                  .WithOne(fd => fd.Funcionario)
                  .HasForeignKey<FuncionarioDetalhe>(fd => fd.FuncionarioId)
                  .IsRequired()
                  .OnDelete(DeleteBehavior.Cascade);

            entity.Property(f => f.Nome).IsRequired().HasMaxLength(100);
            entity.Property(f => f.Cargo).IsRequired().HasMaxLength(100);
            entity.Property(f => f.Salario).IsRequired().HasPrecision(14, 2);

            entity.HasData(
new Funcionario { FuncionarioId = 1, Nome = "Luiz Almeida", Cargo = "Desenvolvedor C#", Salario = 4500.00m, DataContratacao = DateOnly.Parse("10/01/2024"), DepartamentoId = 1 },
new Funcionario { FuncionarioId = 2, Nome = "Mariana Souza", Cargo = "Desenvolvedora Front-end", Salario = 4200.00m, DataContratacao = DateOnly.Parse("15/02/2024"), DepartamentoId = 1 },
new Funcionario { FuncionarioId = 3, Nome = "Carlos Oliveira", Cargo = "Desenvolvedor Back-end", Salario = 4800.00m, DataContratacao = DateOnly.Parse("20/03/2024"), DepartamentoId = 1 },
new Funcionario { FuncionarioId = 4, Nome = "Ana Beatriz Santos", Cargo = "Analista de Sistemas", Salario = 5000.00m, DataContratacao = DateOnly.Parse("05/04/2024"), DepartamentoId = 1 },
new Funcionario { FuncionarioId = 5, Nome = "Rafael Costa", Cargo = "Desenvolvedor Full Stack", Salario = 5500.00m, DataContratacao = DateOnly.Parse("12/05/2024"), DepartamentoId = 1 },

new Funcionario { FuncionarioId = 6, Nome = "Juliana Martins", Cargo = "Pesquisadora", Salario = 3800.00m, DataContratacao = DateOnly.Parse("03/06/2024"), DepartamentoId = 2 },
new Funcionario { FuncionarioId = 7, Nome = "Pedro Henrique Lima", Cargo = "Analista de Pesquisa", Salario = 4000.00m, DataContratacao = DateOnly.Parse("18/06/2024"), DepartamentoId = 2 },
new Funcionario { FuncionarioId = 8, Nome = "Camila Ferreira", Cargo = "UX Researcher", Salario = 4300.00m, DataContratacao = DateOnly.Parse("01/07/2024"), DepartamentoId = 2 },
new Funcionario { FuncionarioId = 9, Nome = "Gabriel Rocha", Cargo = "Cientista de Dados", Salario = 5200.00m, DataContratacao = DateOnly.Parse("15/07/2024"), DepartamentoId = 2 },
new Funcionario { FuncionarioId = 10, Nome = "Beatriz Mendes", Cargo = "Analista de Produtos", Salario = 4700.00m, DataContratacao = DateOnly.Parse("22/08/2024"), DepartamentoId = 2 },

new Funcionario { FuncionarioId = 11, Nome = "Ricardo Gomes", Cargo = "Analista Financeiro", Salario = 4200.00m, DataContratacao = DateOnly.Parse("10/09/2024"), DepartamentoId = 3 },
new Funcionario { FuncionarioId = 12, Nome = "Fernanda Alves", Cargo = "Contadora", Salario = 5000.00m, DataContratacao = DateOnly.Parse("20/09/2024"), DepartamentoId = 3 },
new Funcionario { FuncionarioId = 13, Nome = "Thiago Nunes", Cargo = "Assistente Financeiro", Salario = 3000.00m, DataContratacao = DateOnly.Parse("01/10/2024"), DepartamentoId = 3 },
new Funcionario { FuncionarioId = 14, Nome = "Patricia Ramos", Cargo = "Analista de Custos", Salario = 4500.00m, DataContratacao = DateOnly.Parse("15/10/2024"), DepartamentoId = 3 },
new Funcionario { FuncionarioId = 15, Nome = "Eduardo Castro", Cargo = "Gerente Financeiro", Salario = 6500.00m, DataContratacao = DateOnly.Parse("01/11/2024"), DepartamentoId = 3 },

// Funcionários recentes - Departamento 1
new Funcionario { FuncionarioId = 16, Nome = "Lucas Barbosa", Cargo = "Desenvolvedor C#", Salario = 4400.00m, DataContratacao = DateOnly.Parse("10/03/2026"), DepartamentoId = 1 },
new Funcionario { FuncionarioId = 17, Nome = "Isabela Dias", Cargo = "Desenvolvedora Mobile", Salario = 4600.00m, DataContratacao = DateOnly.Parse("15/06/2026"), DepartamentoId = 1 },

// Funcionários recentes - Departamento 2
new Funcionario { FuncionarioId = 18, Nome = "Bruno Cardoso", Cargo = "Analista de Dados", Salario = 4900.00m, DataContratacao = DateOnly.Parse("01/03/2026"), DepartamentoId = 2 },
new Funcionario { FuncionarioId = 19, Nome = "Larissa Teixeira", Cargo = "Pesquisadora de Mercado", Salario = 4100.00m, DataContratacao = DateOnly.Parse("15/07/2026"), DepartamentoId = 2 },

// Funcionário recente - Departamento 3
new Funcionario { FuncionarioId = 20, Nome = "Gustavo Freitas", Cargo = "Analista Financeiro", Salario = 4300.00m, DataContratacao = DateOnly.Parse("01/08/2026"), DepartamentoId = 3 }
);

        }
    }
}
