using System.Collections.Generic;
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
