using JcmSoft.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.Domain.Entities
{
    public class FuncionarioDetalhe
    {
        public int FuncionarioDetalheId { get; set; }
        public string? EnderecoResidencial { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Celular { get; set; }
        public Genero? Genero { get; set; }
        public string? Foto { get; set; }
        public EstadoCivil? EstadoCivil { get; set; }
        public string? CPF { get; set; }
        public string? Nacionalidade { get; set; }
        public Escolaridade? Escolaridade { get; set; }
        // propriedade de chave estrangeira
        public int FuncionarioId { get; set; }
        // propriedade de navegação de referencia para funcionario
        public Funcionario? Funcionario { get; set; }

        public override string ToString()
        {
            return 
                   $"Endereço: {EnderecoResidencial}\n" +
                   $"Data de Nascimento: {DataNascimento:dd/MM/yyyy}\n" +
                   $"Celular: {Celular}\n" +
                   $"Gênero: {Genero}\n" +
                   $"Foto: {Foto}\n" +
                   $"Estado Civil: {EstadoCivil}\n" +
                   $"CPF: {CPF}\n" +
                   $"Nacionalidade: {Nacionalidade}\n" +
                   $"Escolaridade: {Escolaridade}";
        }
    }
}
