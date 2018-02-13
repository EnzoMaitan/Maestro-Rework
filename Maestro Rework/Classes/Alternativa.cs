using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class Alternativa
    {
        public int Id { get; private set; }
        public Questao Questao { get; private set; }
        public int QuestaoID { get; private set; }
        public string Texto { get; private set; }
        public bool Correta { get; private set; }
    }
}
