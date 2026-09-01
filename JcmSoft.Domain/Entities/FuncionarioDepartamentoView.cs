using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.Domain.Entities
{
    public class FuncionarioDepartamentoView
    {
        public int FuncionarioId { get; set; }
        public string? NomeFuncionario { get; set; }
        public string? Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateOnly DataContratacao { get; set; }
        public int DepartamentoId { get; set; }
        public string? NomeDepartamento { get; set; }
        public string? DescricaoDepartamento { get; set; }



        public override string ToString()
        {
            return $"{FuncionarioId,-15}" +
                   $"{NomeFuncionario,-25}" +
                   $"{Cargo,-20}" +
                   $"{Salario,12:C}" +
                   $"{DataContratacao,15:dd/MM/yyyy}" +
                   $"{DepartamentoId,15}" +
                   $"{NomeDepartamento,-25}" +
                   $"{DescricaoDepartamento,-30}";
        }



    }
}
