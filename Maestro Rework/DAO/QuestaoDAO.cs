using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Entidades;
using Maestro_Rework.IDAO;

namespace Maestro_Rework.DAO
{
    class QuestaoDAO : IQuestaoDAO
    {
        MaestroContext contexto;

        public QuestaoDAO()
        {
            contexto = new MaestroContext();
        }

        public void Adicionar(Questao questao)
        {
            contexto.Questoes.Add(questao);
            contexto.SaveChanges();
        }

        public void Atualizar(Questao questao)
        {
            contexto.Questoes.Update(questao);
            contexto.SaveChanges();
        }

        public IList<Questao> Questoes()
        {
            return contexto.Questoes.ToList();
        }
    }
}
