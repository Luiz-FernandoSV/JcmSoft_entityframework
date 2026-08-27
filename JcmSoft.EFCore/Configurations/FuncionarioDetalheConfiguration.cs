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
    public class FuncionariosConfiguration : IEntityTypeConfiguration<FuncionarioDetalhe>
    {
        public void Configure(EntityTypeBuilder<FuncionarioDetalhe> entity)
        {
            entity.Property(f => f.EnderecoResidencial)
                        .IsRequired()
                        .HasMaxLength(200);
            entity.Property(f => f.Celular)
                    .IsRequired()
                    .HasMaxLength(50);
            entity.Property(f => f.Foto)
                    .IsRequired()
                    .HasMaxLength(200);
            entity.Property(f => f.CPF)
                    .IsRequired()
                    .HasMaxLength(20);
            entity.Property(f => f.Nacionalidade)
                    .IsRequired()
                    .HasMaxLength(50);
            entity.Property(f => f.Genero)
                    .IsRequired();
            entity.Property(f => f.Escolaridade)
                    .IsRequired();
            entity.Property(f => f.EstadoCivil)
                    .IsRequired();

            entity.HasData(
                new FuncionarioDetalhe { FuncionarioDetalheId = 1, EnderecoResidencial = "Rua das Flores, 120", DataNascimento = DateTime.Parse("15/03/1998"), Celular = "11987654321", Genero = Genero.Masculino, Foto = "luiz.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231231", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.Superior, FuncionarioId = 1 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 2, EnderecoResidencial = "Rua Augusta, 450", DataNascimento = DateTime.Parse("22/07/1997"), Celular = "11987654322", Genero = Genero.Feminino, Foto = "mariana.jpg", EstadoCivil = EstadoCivil.Casado, CPF = "50231231232", Nacionalidade = "Brasileira", Escolaridade = Escolaridade.Superior, FuncionarioId = 2 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 3, EnderecoResidencial = "Rua Vergueiro, 890", DataNascimento = DateTime.Parse("10/11/1995"), Celular = "11987654323", Genero = Genero.Masculino, Foto = "carlos.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231233", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.Superior, FuncionarioId = 3 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 4, EnderecoResidencial = "Av. Paulista, 1500", DataNascimento = DateTime.Parse("05/01/1996"), Celular = "11987654324", Genero = Genero.Feminino, Foto = "ana.jpg", EstadoCivil = EstadoCivil.Casado, CPF = "50231231234", Nacionalidade = "Brasileira", Escolaridade = Escolaridade.PosGraduacao, FuncionarioId = 4 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 5, EnderecoResidencial = "Rua Tatuape, 300", DataNascimento = DateTime.Parse("18/09/1994"), Celular = "11987654325", Genero = Genero.Masculino, Foto = "rafael.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231235", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.PosGraduacao, FuncionarioId = 5 },

                new FuncionarioDetalhe { FuncionarioDetalheId = 6, EnderecoResidencial = "Rua Mooca, 220", DataNascimento = DateTime.Parse("12/02/1999"), Celular = "11987654326", Genero = Genero.Feminino, Foto = "juliana.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231236", Nacionalidade = "Brasileira", Escolaridade = Escolaridade.Superior, FuncionarioId = 6 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 7, EnderecoResidencial = "Rua Santana, 720", DataNascimento = DateTime.Parse("28/05/1997"), Celular = "11987654327", Genero = Genero.Masculino, Foto = "pedro.jpg", EstadoCivil = EstadoCivil.Casado, CPF = "50231231237", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.Superior, FuncionarioId = 7 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 8, EnderecoResidencial = "Rua Vila Mariana, 180", DataNascimento = DateTime.Parse("14/08/1996"), Celular = "11987654328", Genero = Genero.Feminino, Foto = "camila.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231238", Nacionalidade = "Brasileira", Escolaridade = Escolaridade.PosGraduacao, FuncionarioId = 8 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 9, EnderecoResidencial = "Rua Ipiranga, 550", DataNascimento = DateTime.Parse("30/12/1993"), Celular = "11987654329", Genero = Genero.Masculino, Foto = "gabriel.jpg", EstadoCivil = EstadoCivil.Casado, CPF = "50231231239", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.PosGraduacao, FuncionarioId = 9 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 10, EnderecoResidencial = "Rua Consolacao, 900", DataNascimento = DateTime.Parse("19/04/1998"), Celular = "11987654330", Genero = Genero.Feminino, Foto = "beatriz.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231240", Nacionalidade = "Brasileira", Escolaridade = Escolaridade.Superior, FuncionarioId = 10 },

                new FuncionarioDetalhe { FuncionarioDetalheId = 11, EnderecoResidencial = "Rua Liberdade, 100", DataNascimento = DateTime.Parse("11/06/1992"), Celular = "11987654331", Genero = Genero.Masculino, Foto = "ricardo.jpg", EstadoCivil = EstadoCivil.Casado, CPF = "50231231241", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.Superior, FuncionarioId = 11 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 12, EnderecoResidencial = "Rua Bela Vista, 340", DataNascimento = DateTime.Parse("23/10/1990"), Celular = "11987654332", Genero = Genero.Feminino, Foto = "fernanda.jpg", EstadoCivil = EstadoCivil.Casado, CPF = "50231231242", Nacionalidade = "Brasileira", Escolaridade = Escolaridade.PosGraduacao, FuncionarioId = 12 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 13, EnderecoResidencial = "Rua Penha, 410", DataNascimento = DateTime.Parse("09/03/2000"), Celular = "11987654333", Genero = Genero.Masculino, Foto = "thiago.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231243", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.Superior, FuncionarioId = 13 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 14, EnderecoResidencial = "Rua Lapa, 670", DataNascimento = DateTime.Parse("17/07/1995"), Celular = "11987654334", Genero = Genero.Feminino, Foto = "patricia.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231244", Nacionalidade = "Brasileira", Escolaridade = Escolaridade.Superior, FuncionarioId = 14 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 15, EnderecoResidencial = "Av. Faria Lima, 2100", DataNascimento = DateTime.Parse("25/01/1988"), Celular = "11987654335", Genero = Genero.Masculino, Foto = "eduardo.jpg", EstadoCivil = EstadoCivil.Casado, CPF = "50231231245", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.PosGraduacao, FuncionarioId = 15 },

                new FuncionarioDetalhe { FuncionarioDetalheId = 16, EnderecoResidencial = "Rua Carrão, 230", DataNascimento = DateTime.Parse("08/09/1999"), Celular = "11987654336", Genero = Genero.Masculino, Foto = "lucas.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231246", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.Superior, FuncionarioId = 16 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 17, EnderecoResidencial = "Rua Butanta, 580", DataNascimento = DateTime.Parse("16/12/1998"), Celular = "11987654337", Genero = Genero.Feminino, Foto = "isabela.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231247", Nacionalidade = "Brasileira", Escolaridade = Escolaridade.Superior, FuncionarioId = 17 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 18, EnderecoResidencial = "Rua Pinheiros, 760", DataNascimento = DateTime.Parse("02/02/1996"), Celular = "11987654338", Genero = Genero.Masculino, Foto = "bruno.jpg", EstadoCivil = EstadoCivil.Casado, CPF = "50231231248", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.PosGraduacao, FuncionarioId = 18 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 19, EnderecoResidencial = "Rua Santana, 820", DataNascimento = DateTime.Parse("21/05/1997"), Celular = "11987654339", Genero = Genero.Feminino, Foto = "larissa.jpg", EstadoCivil = EstadoCivil.Solteiro, CPF = "50231231249", Nacionalidade = "Brasileira", Escolaridade = Escolaridade.Superior, FuncionarioId = 19 },
                new FuncionarioDetalhe { FuncionarioDetalheId = 20, EnderecoResidencial = "Rua Moema, 450", DataNascimento = DateTime.Parse("13/11/1994"), Celular = "11987654340", Genero = Genero.Masculino, Foto = "gustavo.jpg", EstadoCivil = EstadoCivil.Casado, CPF = "50231231250", Nacionalidade = "Brasileiro", Escolaridade = Escolaridade.Superior, FuncionarioId = 20 }
            );

        }
    }
}
