using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;
using Maestro_Rework.IDAO;

namespace Maestro_Rework.DAO
{
    public class UsuarioDAO : IDisposable, IUsuarioDAO
    {
        private MaestroContext contexto;

        public bool ValidarLogin(string login, string senha)
        {
            using (var contexto = new MaestroContext())
            {
                var query = contexto.Usuarios.Where(x => x.Login == login && x.Senha == senha);
                if (query.FirstOrDefault() != null)
                    return true;
                else throw new Exception("Usuario Invalido");
            }
        }

        public bool NomeDisponivel(string login)
        {
            using (var contexto = new MaestroContext())
            {
                var LoginEmUso = contexto.Usuarios.Where(x => x.Login == login);
                if (LoginEmUso.FirstOrDefault() == null) return true;
                else throw new Exception("Login já em uso");
            }
        }

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
