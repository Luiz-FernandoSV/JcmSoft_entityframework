using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.Domain.Entities
{
    public class Departamento
    {

        public int DepartamentoId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        // propriedade de navegação de coleção
        public ICollection<Funcionario> Funcionarios { get; set; }
        public Departamento()
        {
            Funcionarios = new List<Funcionario>();
        }
    }

}
