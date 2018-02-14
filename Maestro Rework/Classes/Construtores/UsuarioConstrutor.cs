using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Construtores
{
    class UsuarioConstrutor
    {
        public string Login { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public int Nivel { get; private set; }
        public string Cargo { get; private set; }

        public UsuarioConstrutor ParaLogin(string login)
        {
            Login = login;
            return this;
        }
        public UsuarioConstrutor ParaNome(string nome)
        {
            Nome = nome;
            return this;
        }
        public UsuarioConstrutor ParaSenha(string senha)
        {
            Senha = senha;
            return this;
        }
        public UsuarioConstrutor ParaEmail(string email)
        {
            Email = email;
            return this;
        }
        public UsuarioConstrutor ParaNivel(int nivel)
        {
            Nivel = nivel;
            return this;
        }

        public UsuarioConstrutor ParaCargo(string cargo)
        {
            Cargo = cargo;
            return this;
        }

        public Usuario Constroi()
        {
            return new Usuario(Login, Nome, Senha, Email, Nivel, Cargo);
        }
    }
}
