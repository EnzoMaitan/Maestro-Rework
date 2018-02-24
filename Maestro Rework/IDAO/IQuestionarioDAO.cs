using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;

namespace Maestro_Rework.IDAO
{
    interface IQuestionarioDAO
    {
        void Adicionar(Questionario questionario);
        void Atualizar(Questionario questionario);
        IList<Questionario> Questionario();
    }
}
