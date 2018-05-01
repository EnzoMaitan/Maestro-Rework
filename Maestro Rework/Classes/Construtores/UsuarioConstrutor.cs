using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Entidades;

namespace Maestro_Rework.Classes.Construtores
{
    class UsuarioConstrutor
    {
        public string Login { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }

        public UsuarioConstrutor ParaLogin(string login)
        {
            Login = login;
            return this;
        }
        public UsuarioConstrutor ParaNome(string nome)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
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

        public Aluno ConstroiAluno()
        {
            return new Aluno(Login, Nome, Senha, Email);
        }

        public Professor ConstroiProfessor()
        {
            return new Professor(Login, Nome, Senha, Email);
        }

        public Administrador ConstroiAdministrador()
        {
            return new Administrador(Login, Nome, Senha, Email);
        }
    }
}
