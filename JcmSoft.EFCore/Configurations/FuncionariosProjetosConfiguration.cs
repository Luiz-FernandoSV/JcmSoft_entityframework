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
    public class FuncionariosProjetosConfiguration : IEntityTypeConfiguration<FuncionariosProjetos>
    {
        public void Configure(EntityTypeBuilder<FuncionariosProjetos> entity)
        {

            entity.HasKey(fp => new { fp.FuncionarioId, fp.ProjetoId });

            entity.HasOne(fp => fp.Funcionario)
                  .WithMany(f => f.FuncionarioProjetos)
                  .HasForeignKey(fp => fp.FuncionarioId);

            entity.HasOne(fp => fp.Projeto)
                  .WithMany(f => f.FuncionarioProjetos)
                  .HasForeignKey(fp => fp.ProjetoId);

            entity.HasData(
                    new FuncionariosProjetos { FuncionarioId = 1, ProjetoId = 1, HorasTrabalhadas = 80 },
                    new FuncionariosProjetos { FuncionarioId = 2, ProjetoId = 1, HorasTrabalhadas = 60 },
                    new FuncionariosProjetos { FuncionarioId = 3, ProjetoId = 2, HorasTrabalhadas = 90 },
                    new FuncionariosProjetos { FuncionarioId = 4, ProjetoId = 2, HorasTrabalhadas = 70 },
                    new FuncionariosProjetos { FuncionarioId = 5, ProjetoId = 3, HorasTrabalhadas = 100 },

                    new FuncionariosProjetos { FuncionarioId = 6, ProjetoId = 4, HorasTrabalhadas = 100 },
                    new FuncionariosProjetos { FuncionarioId = 7, ProjetoId = 5, HorasTrabalhadas = 100 },
                    new FuncionariosProjetos { FuncionarioId = 8, ProjetoId = 6, HorasTrabalhadas = 100 },
                    new FuncionariosProjetos { FuncionarioId = 9, ProjetoId = 7, HorasTrabalhadas = 100 },
                    new FuncionariosProjetos { FuncionarioId = 10, ProjetoId = 8, HorasTrabalhadas = 100 },

                    new FuncionariosProjetos { FuncionarioId = 11, ProjetoId = 9, HorasTrabalhadas = 40 },
                    new FuncionariosProjetos { FuncionarioId = 12, ProjetoId = 10, HorasTrabalhadas = 100 },
                    new FuncionariosProjetos { FuncionarioId = 13, ProjetoId = 11, HorasTrabalhadas = 100 },
                    new FuncionariosProjetos { FuncionarioId = 14, ProjetoId = 12, HorasTrabalhadas = 70 },
                    new FuncionariosProjetos { FuncionarioId = 15, ProjetoId = 13, HorasTrabalhadas = 35 },

                    new FuncionariosProjetos { FuncionarioId = 16, ProjetoId = 14, HorasTrabalhadas = 80 },
                    new FuncionariosProjetos { FuncionarioId = 17, ProjetoId = 15, HorasTrabalhadas = 100 },
                    new FuncionariosProjetos { FuncionarioId = 18, ProjetoId = 16, HorasTrabalhadas = 100 },
                    new FuncionariosProjetos { FuncionarioId = 19, ProjetoId = 17, HorasTrabalhadas = 50 },
                    new FuncionariosProjetos { FuncionarioId = 20, ProjetoId = 18, HorasTrabalhadas = 100 },

                    // Alguns funcionários participam de mais de um projeto
                    new FuncionariosProjetos { FuncionarioId = 1, ProjetoId = 19, HorasTrabalhadas = 100 },
                    new FuncionariosProjetos { FuncionarioId = 3, ProjetoId = 20, HorasTrabalhadas = 55 },
                    new FuncionariosProjetos { FuncionarioId = 5, ProjetoId = 4, HorasTrabalhadas = 30 },
                    new FuncionariosProjetos { FuncionarioId = 8, ProjetoId = 10, HorasTrabalhadas = 25 },
                    new FuncionariosProjetos { FuncionarioId = 12, ProjetoId = 19, HorasTrabalhadas = 35 }
                );


        }
    }
}
