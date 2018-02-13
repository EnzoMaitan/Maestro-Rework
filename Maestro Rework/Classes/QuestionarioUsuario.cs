using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public  class QuestionarioUsuario
    {
        public int Id { get; private set; }

        public Usuario Usuario { get; private set; }
        public int UsuarioID { get; private set; }
        public Questionario Questionario { get; private set; }
        public int QuestionarioID { get; private set; }

        public bool Acesso { get; private set; }
        public bool Refez { get; private set; }

        public IList<AlternativaCorreta> AlternativaCorretas { get; private set; }
    }
}
