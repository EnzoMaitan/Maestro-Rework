using Maestro_Rework.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.IDAO
{
    interface IAnexoConteudoDAO
    {
        void Adicionar(AnexoConteudo anexoConteudo);
        void Atualizar(AnexoConteudo anexoConteudo);
        IList<AnexoConteudo> AnexoConteudos();
    }
}
