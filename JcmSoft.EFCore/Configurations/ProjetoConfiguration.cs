using JcmSoft.Domain.Entities;
using JcmSoft.Domain.Enums;
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
    public class ProjetoConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> entity)
        {
            entity.Property(e => e.Nome).HasMaxLength(100).IsRequired();
            entity.Property(e => e.Descricao).HasMaxLength(200).IsRequired();
            entity.Property(e => e.Orcamento).HasPrecision(20, 2);
            entity.Property(e => e.DuracaoEmDias).HasComputedColumnSql("DATEDIFF(day,DataInico,DataFim)", stored: true);

            entity.HasData(
                new Projeto { ProjetoId = 1, ClienteId = 1, Nome = "Sistema Gulosos", Orcamento = 15000.00m, Descricao = "Sistema de vendas", DataInico = DateTime.Parse("01/01/2026"), DataAtualizacao = DateTime.Parse("20/08/2026"), DataFim = DateTime.Parse("30/09/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 2, ClienteId = 2, Nome = "Portal TechNova", Orcamento = 28000.00m, Descricao = "Portal corporativo", DataInico = DateTime.Parse("10/01/2026"), DataAtualizacao = DateTime.Parse("15/08/2026"), DataFim = DateTime.Parse("30/10/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 3, ClienteId = 3, Nome = "Sistema Mercado", Orcamento = 22000.00m, Descricao = "Sistema de estoque", DataInico = DateTime.Parse("15/01/2026"), DataAtualizacao = DateTime.Parse("18/08/2026"), DataFim = DateTime.Parse("15/09/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 4, ClienteId = 4, Nome = "App Hospital Vida", Orcamento = 35000.00m, Descricao = "Aplicativo hospitalar", DataInico = DateTime.Parse("01/02/2026"), DataAtualizacao = DateTime.Parse("20/08/2026"), DataFim = DateTime.Parse("30/11/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 5, ClienteId = 5, Nome = "Sistema de Entregas", Orcamento = 18000.00m, Descricao = "Controle de entregas", DataInico = DateTime.Parse("10/02/2026"), DataAtualizacao = DateTime.Parse("19/08/2026"), DataFim = DateTime.Parse("10/10/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 6, ClienteId = 6, Nome = "Portal Escola Futuro", Orcamento = 25000.00m, Descricao = "Portal acadêmico", DataInico = DateTime.Parse("01/03/2026"), DataAtualizacao = DateTime.Parse("15/08/2026"), DataFim = DateTime.Parse("30/09/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 7, ClienteId = 7, Nome = "App Restaurante", Orcamento = 12000.00m, Descricao = "Aplicativo de pedidos", DataInico = DateTime.Parse("15/03/2026"), DataAtualizacao = DateTime.Parse("10/08/2026"), DataFim = DateTime.Parse("15/09/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 8, ClienteId = 8, Nome = "Gestao de Obras", Orcamento = 32000.00m, Descricao = "Sistema de obras", DataInico = DateTime.Parse("01/04/2026"), DataAtualizacao = DateTime.Parse("12/08/2026"), DataFim = DateTime.Parse("30/11/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 9, ClienteId = 9, Nome = "App Academia", Orcamento = 14000.00m, Descricao = "Aplicativo fitness", DataInico = DateTime.Parse("10/04/2026"), DataAtualizacao = DateTime.Parse("18/08/2026"), DataFim = DateTime.Parse("30/09/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 10, ClienteId = 10, Nome = "Internet Banking", Orcamento = 50000.00m, Descricao = "Sistema bancário", DataInico = DateTime.Parse("01/05/2026"), DataAtualizacao = DateTime.Parse("20/08/2026"), DataFim = DateTime.Parse("31/12/2026"), Status = StatusProjeto.Iniciado },

                new Projeto { ProjetoId = 11, ClienteId = 11, Nome = "Agenda Clinica", Orcamento = 16000.00m, Descricao = "Sistema de consultas", DataInico = DateTime.Parse("10/05/2026"), DataAtualizacao = DateTime.Parse("17/08/2026"), DataFim = DateTime.Parse("30/09/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 12, ClienteId = 12, Nome = "E-commerce Livraria", Orcamento = 27000.00m, Descricao = "Loja virtual", DataInico = DateTime.Parse("01/06/2026"), DataAtualizacao = DateTime.Parse("20/08/2026"), DataFim = DateTime.Parse("30/11/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 13, ClienteId = 13, Nome = "Pet Feliz Online", Orcamento = 13000.00m, Descricao = "Sistema pet shop", DataInico = DateTime.Parse("10/06/2026"), DataAtualizacao = DateTime.Parse("15/08/2026"), DataFim = DateTime.Parse("30/09/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 14, ClienteId = 14, Nome = "Auto Center App", Orcamento = 19000.00m, Descricao = "Agendamento oficina", DataInico = DateTime.Parse("15/06/2026"), DataAtualizacao = DateTime.Parse("18/08/2026"), DataFim = DateTime.Parse("30/10/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 15, ClienteId = 15, Nome = "Hotel Central", Orcamento = 24000.00m, Descricao = "Sistema hoteleiro", DataInico = DateTime.Parse("01/07/2026"), DataAtualizacao = DateTime.Parse("20/08/2026"), DataFim = DateTime.Parse("30/11/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 16, ClienteId = 16, Nome = "Farmacia Online", Orcamento = 21000.00m, Descricao = "E-commerce farmacia", DataInico = DateTime.Parse("10/07/2026"), DataAtualizacao = DateTime.Parse("19/08/2026"), DataFim = DateTime.Parse("30/10/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 17, ClienteId = 17, Nome = "Comercial Andrade", Orcamento = 17000.00m, Descricao = "Sistema comercial", DataInico = DateTime.Parse("15/07/2026"), DataAtualizacao = DateTime.Parse("20/08/2026"), DataFim = DateTime.Parse("30/09/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 18, ClienteId = 18, Nome = "Portal Alpha", Orcamento = 30000.00m, Descricao = "Portal educacional", DataInico = DateTime.Parse("01/08/2026"), DataAtualizacao = DateTime.Parse("20/08/2026"), DataFim = DateTime.Parse("31/12/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 19, ClienteId = 19, Nome = "Metal Forte ERP", Orcamento = 45000.00m, Descricao = "ERP industrial", DataInico = DateTime.Parse("01/08/2026"), DataAtualizacao = DateTime.Parse("22/08/2026"), DataFim = DateTime.Parse("31/12/2026"), Status = StatusProjeto.Iniciado },
                new Projeto { ProjetoId = 20, ClienteId = 20, Nome = "Logistica Express", Orcamento = 26000.00m, Descricao = "Sistema logístico", DataInico = DateTime.Parse("10/08/2026"), DataAtualizacao = DateTime.Parse("22/08/2026"), DataFim = DateTime.Parse("30/11/2026"), Status = StatusProjeto.Iniciado }
            );
        }
    }
}
