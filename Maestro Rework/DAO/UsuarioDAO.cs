using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;


namespace Maestro_Rework.DAO
{
    public class UsuarioDAO : IDisposable
    {
        private MaestroContext contexto;

        public UsuarioDAO()
        {
            contexto = new MaestroContext();
        }

        public void Adicionar(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            contexto.Usuarios.Update(usuario);
            contexto.SaveChanges();
        }

        public IList<Usuario> Usuario()
        {
            return contexto.Usuarios.ToList();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
