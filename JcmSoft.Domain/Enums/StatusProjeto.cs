using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.Domain.Enums
{
    public enum StatusProjeto
    {
        EmAprovacao = 3,
        Iniciado = 10,
        EmAndamento = 20,
        EmRevisao = 5,
        Parado = 0,
        Adiado = 1,
        Concluido = 100,
        Cancelado = -1,
    }
}
