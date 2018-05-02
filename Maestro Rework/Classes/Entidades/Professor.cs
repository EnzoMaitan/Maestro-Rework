using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class Professor : Usuario
    {
        public Professor()
        {
                
        }
        public Professor(string login, string nome, string senha, string email)
        {
            CheckarNull(login, nome, senha, email);

            Login = login;
            Nome = nome;
            Senha = BCrypt.Net.BCrypt.HashPassword(senha);
            Email = email;
            Nivel = 3;
            Nivel = 2;
            CodigoSenha = null;
            Cargo = "Professor";
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
    }
}
