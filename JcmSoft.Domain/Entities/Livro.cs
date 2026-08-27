using JcmSoft.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcmSoft.Domain.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DataPublicacao { get; set; }
        public StatusLivro Status { get; set; }

        public override string ToString()
        {
            return Id + " - " + Titulo + " Esta deletado: " + IsDeleted + " Data publicação: " + DataPublicacao + " Status: " + Status;

        }

    }
}
