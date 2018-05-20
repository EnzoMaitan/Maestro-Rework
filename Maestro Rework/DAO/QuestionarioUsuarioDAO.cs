using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Entidades;
using Maestro_Rework.IDAO;

namespace Maestro_Rework.DAO
{
    public class QuestionarioUsuarioDAO : IQuestionarioUsuarioDAO
    {
        private MaestroContext contexto;

        public QuestionarioUsuarioDAO()
        {
            contexto = new MaestroContext();
        }

        public void Adicionar(QuestionarioUsuario questionarioUsuario)
        {
            contexto.QuestionarioUsuarios.Add(questionarioUsuario);
            contexto.SaveChanges();
        }

        public void Atualizar(QuestionarioUsuario questionarioUsuario)
        {
            contexto.QuestionarioUsuarios.Update(questionarioUsuario);
            contexto.SaveChanges();
        }

        public IList<QuestionarioUsuario> QuestionarioUsuario() => 
            contexto.QuestionarioUsuarios.ToList();
    }
}
