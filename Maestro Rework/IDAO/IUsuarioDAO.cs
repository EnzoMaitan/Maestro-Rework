using System.Collections.Generic;
using Maestro_Rework.Classes.Entidades;

namespace Maestro_Rework.IDAO
{
    public interface IUsuarioDAO
    {
        void Adicionar(Usuario usuario);
        void Atualizar(Usuario usuario);
        bool LoginDisponivel(string login);
        string PegarHashSalvo(string login);
        Usuario GetUsuarioLogado(string login, string senha);
        IList<Usuario> Usuario();
    }
}
