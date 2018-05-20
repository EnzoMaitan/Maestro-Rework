using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Entidades;
namespace Maestro_Rework.IDAO
{
    interface IQuestionarioUsuarioDAO
    {
        void Adicionar(QuestionarioUsuario questionarioUsuario);
        void Atualizar(QuestionarioUsuario questionarioUsuario);
        IList<QuestionarioUsuario> QuestionarioUsuario();
    }
}
