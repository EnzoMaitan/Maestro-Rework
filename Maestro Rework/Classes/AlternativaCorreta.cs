using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class AlternativaCorreta
    {
        public int AlternativaID { get; private set; }
        public int Tentativa { get; private set; }

        public virtual QuestionarioUsuario QuestionarioUsuario { get; private set; }
        public int QuestionarioUsuarioID { get; private set; }  
    }
}
