using Maestro_Rework.Classes.Entidades;
using System.Collections.Generic;

namespace Maestro_Rework.IDAO
{
    interface IConteudoDAO
    {
        void Adicionar(Conteudo conteudo);
        void Atualizar(Conteudo conteudo);
        IList<Conteudo> Conteudo();
    }
}
