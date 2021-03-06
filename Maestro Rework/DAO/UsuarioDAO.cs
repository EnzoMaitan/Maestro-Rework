﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;
using Maestro_Rework.IDAO;
using Maestro_Rework.Classes.Entidades;


namespace Maestro_Rework.DAO
{
    public class UsuarioDAO : IDisposable, IUsuarioDAO
    {
        private MaestroContext contexto;

        public string PegarHashSalvo(string login)
        {
            using (var contexto = new MaestroContext())
            {
                var query = contexto.Usuarios.Where(x => x.Login.Equals(login));
                if (query.FirstOrDefault() != null)
                    return query.FirstOrDefault().Senha;
                else throw new Exception("Usuario Invalido");
            }
        }

        public bool LoginDisponivel(string login)
        {
            using (var contexto = new MaestroContext())
            {
                var LoginEmUso = contexto.Usuarios.Where(x => x.Login == login);
                if (LoginEmUso.FirstOrDefault() == null) return true;
                else throw new Exception("Login já em uso");
            }
        }

        public Usuario GetUsuarioLogado(string login, string senha)
        {
            using (var contexto = new MaestroContext())
            {
                var LoginEmUso = contexto.Usuarios.Where(x => x.Login == login);
                return LoginEmUso.FirstOrDefault();
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

        public IList<Usuario> Usuario() => contexto.Usuarios.ToList();
        

        public void Dispose()
        {
            ((IDisposable)contexto).Dispose();
        }
    }
}
