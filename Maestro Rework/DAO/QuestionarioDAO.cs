using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;
using Maestro_Rework.IDAO;

namespace Maestro_Rework.DAO
{
    class QuestionarioDAO : IQuestionarioDAO, IDisposable
    {
        private MaestroContext contexto;

        public QuestionarioDAO()
        {
            contexto = new MaestroContext();
        }

        public void Adicionar(Questionario questionario)
        {
            contexto.Questionarios.Add(questionario);
            contexto.SaveChanges();
        }

        public void Atualizar(Questionario questionario)
        {
            contexto.Questionarios.Update(questionario);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            ((IDisposable)contexto).Dispose();
        }

        public IList<Questionario> Questionario() => contexto.Questionarios.ToList();
    }
}
