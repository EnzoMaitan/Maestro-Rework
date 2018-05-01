using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class RegistraQuestionario
    {
        public int Id { get; private set; }
        public Questionario Questionario { get; private set; }
        public int QuestionarioID { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
    }
}
