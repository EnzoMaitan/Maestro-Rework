using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.DAO;
using BCrypt;

namespace Maestro_Rework.Classes.Entidades
{
    public abstract class Usuario
    {
        public int Id { get; protected set; }
        public IList<UsuarioConteudo> Conteudos { get; set; }
        public IList<RegistroUsuario> Registros { get; set; }

        public string Login { get; protected set; }
        public string Nome { get; protected set; }
        public string Senha { get; protected set; }
        public string Email { get; protected set; }
        public int Nivel { get; protected set; }
        public bool Ativo { get; protected set; }
        public string CodigoSenha { get; set; }
        public string Cargo { get; protected set; }
        public bool Verificado { get; protected set; }
        public DateTime DataCriacao { get; protected set; }

        public Usuario() { }

        public Usuario(string login, string nome, string senha, string email)
        {
            CheckarNull(login, nome, senha, email);
            Login = login;
            Nome = nome;
            Senha = BCrypt.Net.BCrypt.HashPassword(senha);
            Email = email;
            CodigoSenha = null;
            DataCriacao = DateTime.Now;
            Ativo = true;
            Verificado = false;
        }

        private static void CheckarNull(string login, string nome, string senha, string email)
        {
            if (string.IsNullOrWhiteSpace(login)) throw new ArgumentNullException(nameof(login));
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException(nameof(nome));
            if (string.IsNullOrWhiteSpace(senha)) throw new ArgumentNullException(nameof(senha));
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentNullException(nameof(email));
        }

        public bool CheckarEmailConfirmado()
        {
            if (Verificado) return true;
            else throw new Exception("Email Não Confirmado");
        }

        public void AtualizarSenha(string senha)
        {
            Senha = BCrypt.Net.BCrypt.HashPassword(senha);
        }

        public static bool ValidarLogin(string login, string senha)
        {         
            UsuarioDAO dao = new UsuarioDAO();
            var hashSalvo = dao.PegarHashSalvo(login);
            if(BCrypt.Net.BCrypt.Verify(senha, hashSalvo))
                return true;
            else throw new Exception("Usuario Invalido");
        }
    }
}
