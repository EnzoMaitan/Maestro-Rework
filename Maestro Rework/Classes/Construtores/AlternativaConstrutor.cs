using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;

namespace Maestro_Rework.Classes.Construtores
{
    class AlternativaConstrutor : IDisposable
    {
        public int QuestaoID { get; private set; }
        public string Texto { get; private set; }
        public bool Correta { get; private set; }

        public AlternativaConstrutor ParaQuestao(Questao questao)
        {
            QuestaoID = questao.Id;
            return this;
        }

        public AlternativaConstrutor ParaTexto(string texto)
        {
            Texto = texto;
            return this;
        }

        public AlternativaConstrutor ParaCorreta(bool correta)
        {
            Correta = correta;
            return this;
        }

        public Alternativa Constroi()
        {
            return new Alternativa(QuestaoID, Texto, Correta);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
