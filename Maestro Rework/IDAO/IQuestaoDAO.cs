using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Entidades;

namespace Maestro_Rework.IDAO
{
    interface IQuestaoDAO
    {
        void Adicionar(Questao questao);
        void Atualizar(Questao questao);
        IList<Questao> Questoes();
    }
}
