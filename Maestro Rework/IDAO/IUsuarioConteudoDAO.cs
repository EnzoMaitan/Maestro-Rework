using Maestro_Rework.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.IDAO
{
    interface IUsuarioConteudoDAO
    {
        void Adicionar(UsuarioConteudo anexoConteudo);
        void Atualizar(UsuarioConteudo anexoConteudo);
        IList<UsuarioConteudo> UsuarioConteudos();
    }
}
