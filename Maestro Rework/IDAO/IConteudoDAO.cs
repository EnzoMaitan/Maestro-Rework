using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;

namespace Maestro_Rework.IDAO
{
    interface IConteudoDAO
    {
        void Adicionar(Conteudo conteudo);
        void Atualizar(Conteudo conteudo);
        IList<Conteudo> Conteudo();
    }
}
