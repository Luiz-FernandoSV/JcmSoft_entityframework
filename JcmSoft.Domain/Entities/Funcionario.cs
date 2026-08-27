using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.Domain.Entities
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Salario { get; set; }
        public DateOnly DataContratacao { get; set; }
        // propriedade de chave estrangeira
        public int DepartamentoId { get; set; }
        // propriedade de navegação de referencia
        public Departamento? Departamento { get; set; }
        public FuncionarioDetalhe? FuncionarioDetalhe { get; set; }

        public ICollection<FuncionariosProjetos> FuncionarioProjetos { get; set; } = new List<FuncionariosProjetos>();

        public override string ToString()
        {
            return "ID: " + this.FuncionarioId + " | Nome: " + this.Nome + " | Cargo: " + this.Cargo + " | Salario: " + this.Salario + " | Data de contratacao: " + this.DataContratacao;
        }
    }
}
