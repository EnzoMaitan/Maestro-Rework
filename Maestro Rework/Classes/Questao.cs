using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class Questao
    {
        public int Id { get; private set; }
        public Questionario Questionario { get; private set; }
        public int QuestionarioID { get; private set; }
        public IList<Alternativa> Alternativas { get; private set; }
        public string Pergunta { get; private set; }
        public double Valor { get; private set; }
        public byte[] Imagem { get; private set; }  
    }
}
