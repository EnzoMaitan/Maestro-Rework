using Maestro_Rework.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.IDAO
{
    interface IAlternativaDAO
    {
        void Adicionar(Alternativa alternativa);
        void Atualizar(Alternativa alternativa);
        IList<Alternativa> Alternativas();
    }
}
