using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class UsuarioConteudo
    {
        public Usuario Usuario { get; private set; }
        public int UsuarioID { get; private set; }
        public Conteudo Conteudo { get; private set; }
        public int ConteudoID { get; private set; }
        public bool Acesso { get; private set; }
    }
}
