﻿using System.Collections.Generic;
using Maestro_Rework.Classes;

namespace Maestro_Rework.IDAO
{
    public interface IUsuarioDAO
    {
        void Adicionar(Usuario usuario);
        void Atualizar(Usuario usuario);
        bool LoginDisponivel(string login);
        bool ValidarLogin(string login, string senha);
        Usuario GetUsuarioLogado(string login, string senha);
        IList<Usuario> Usuario();
    }
}
