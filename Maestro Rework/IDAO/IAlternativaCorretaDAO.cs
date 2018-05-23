using Maestro_Rework.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.IDAO
{
    interface IAlternativaCorretaDAO
    {
        void Adicionar(AlternativaCorreta alternativaCorreta);
        void Atualizar(AlternativaCorreta alternativaCorreta);
        IList<AlternativaCorreta> alternativaCorretas();
    }
}
