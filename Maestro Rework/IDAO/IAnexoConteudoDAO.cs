using Maestro_Rework.Classes.Entidades;
using System.Collections.Generic;

namespace Maestro_Rework.IDAO
{
    interface IAnexoConteudoDAO
    {
        void Adicionar(AnexoConteudo anexoConteudo);
        void Atualizar(AnexoConteudo anexoConteudo);
        IList<AnexoConteudo> AnexoConteudos();
    }
}
