using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Entidades;
using Maestro_Rework.IDAO;

namespace Maestro_Rework.DAO
{
    public class UsuarioConteudoDAO : IUsuarioConteudoDAO
    {
        MaestroContext contexto;

        public UsuarioConteudoDAO()
        {
            contexto = new MaestroContext();
        }

        public void Adicionar(UsuarioConteudo usuarioConteudo)
        {
            contexto.UsuarioConteudos.Add(usuarioConteudo);
            contexto.SaveChanges();
        }

        public void Atualizar(UsuarioConteudo usuarioConteudo)
        {
            contexto.UsuarioConteudos.Update(usuarioConteudo);
            contexto.SaveChanges();
        }

        public IList<UsuarioConteudo> UsuarioConteudos() => contexto.UsuarioConteudos.ToList();   
    }
}
