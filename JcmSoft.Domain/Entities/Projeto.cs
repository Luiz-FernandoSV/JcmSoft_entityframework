using JcmSoft.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.Domain.Entities
{
    public class Projeto
    {
        public int ProjetoId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Orcamento { get; set; }
        public DateTime DataInico { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataFim { get; set; }
        public StatusProjeto Status { get; set; }

        // propriedade de navegação para a relação muitos-para-muitos com funcionario
        public ICollection<FuncionariosProjetos> FuncionarioProjetos { get; set; } = new List<FuncionariosProjetos>();

        // chave estrangeira para cliente
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public override string ToString()
        {
            return
                $"Projeto: {Nome}\n" +
                $"Descrição: {Descricao}\n" +
                $"Orçamento: {Orcamento:C}\n" +
                $"Data de Início: {DataInico:dd/MM/yyyy}\n" +
                $"Data de Atualização: {DataAtualizacao:dd/MM/yyyy}\n" +
                $"Data de Fim: {DataFim:dd/MM/yyyy}\n" +
                $"Status: {Status}\n" +
                $"Cliente: {Cliente?.Nome}";
        }
    }
}
