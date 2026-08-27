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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.Property(e => e.Nome).HasMaxLength(100).IsRequired();
            entity.Property(e => e.Email).HasMaxLength(200).IsRequired();
            entity.Property(e => e.Telefone).HasMaxLength(50).IsRequired();

            entity.HasData(
                new Cliente { ClienteId = 1, Nome = "Gulos Softwares", Email = "contato@gulossw.com", Telefone = "1130121001" },
                new Cliente { ClienteId = 2, Nome = "TechNova Solutions", Email = "contato@technova.com", Telefone = "1130121002" },
                new Cliente { ClienteId = 3, Nome = "Mercado Bom Preco", Email = "contato@bompreco.com", Telefone = "1130121003" },
                new Cliente { ClienteId = 4, Nome = "Hospital Vida", Email = "contato@hospitalvida.com", Telefone = "1130121004" },
                new Cliente { ClienteId = 5, Nome = "Transportadora Rapida", Email = "contato@transrapida.com", Telefone = "1130121005" },
                new Cliente { ClienteId = 6, Nome = "Escola Futuro", Email = "contato@escolafuturo.com", Telefone = "1130121006" },
                new Cliente { ClienteId = 7, Nome = "Restaurante Sabor", Email = "contato@restaurantesabor.com", Telefone = "1130121007" },
                new Cliente { ClienteId = 8, Nome = "Construtora Horizonte", Email = "contato@horizonte.com", Telefone = "1130121008" },
                new Cliente { ClienteId = 9, Nome = "Academia Movimento", Email = "contato@movimento.com", Telefone = "1130121009" },
                new Cliente { ClienteId = 10, Nome = "Banco Paulista", Email = "contato@bancopaulista.com", Telefone = "1130121010" },
                new Cliente { ClienteId = 11, Nome = "Clinica Central", Email = "contato@clinicacentral.com", Telefone = "1130121011" },
                new Cliente { ClienteId = 12, Nome = "Livraria Cultura", Email = "contato@livrariacultura.com", Telefone = "1130121012" },
                new Cliente { ClienteId = 13, Nome = "Pet Feliz", Email = "contato@petfeliz.com", Telefone = "1130121013" },
                new Cliente { ClienteId = 14, Nome = "Auto Center Brasil", Email = "contato@autocenter.com", Telefone = "1130121014" },
                new Cliente { ClienteId = 15, Nome = "Hotel Central", Email = "contato@hotelcentral.com", Telefone = "1130121015" },
                new Cliente { ClienteId = 16, Nome = "Farmacia Saude", Email = "contato@farmaciasaude.com", Telefone = "1130121016" },
                new Cliente { ClienteId = 17, Nome = "Comercial Andrade", Email = "contato@comercialandrade.com", Telefone = "1130121017" },
                new Cliente { ClienteId = 18, Nome = "Grupo Educacional Alpha", Email = "contato@grupoalpha.com", Telefone = "1130121018" },
                new Cliente { ClienteId = 19, Nome = "Industria Metal Forte", Email = "contato@metalforte.com", Telefone = "1130121019" },
                new Cliente { ClienteId = 20, Nome = "Logistica Express", Email = "contato@logisticaexpress.com", Telefone = "1130121020" }
            );


        }
    }
}
