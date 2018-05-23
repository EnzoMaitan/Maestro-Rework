using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class AlternativaCorreta
    {
        public int AlternativaID { get;  set; }
        public int Tentativa { get;  set; }

        public virtual QuestionarioUsuario QuestionarioUsuario { get;  set; }
        public int QuestionarioUsuarioID { get;  set; }  
    }
}
