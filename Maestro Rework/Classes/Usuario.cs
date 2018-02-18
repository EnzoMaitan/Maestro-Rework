using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class Usuario
    {
        public Usuario(string login, string nome, string senha, string email, int nivel, string cargo)
        {
            Login = login;
            Nome = nome;
            Senha = senha;
            Email = email;
            Nivel = nivel;
            CodigoSenha = null;
            Cargo = cargo;
            DataCriacao = DateTime.Now;
            Ativo = true;
            Verificado = false;
        }
        public Usuario()
        {

        }

        public void AtualizarSenha(string senha)
        {
            Senha = senha;
        }
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public int Nivel { get; private set; }
        public bool Ativo { get; private set; }
        public string CodigoSenha { get; private set; }
        public string Cargo { get; private set; }
        public bool Verificado { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public IList<UsuarioConteudo> Conteudos { get; set; }
        public IList<RegistroUsuario> Registros { get; set; }
    }
}
