using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class RegistroConteudo
    {
        public int Id { get; private set; }
        public Conteudo Conteudo { get; private set; }
        public int ConteudoID { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
    }
}
