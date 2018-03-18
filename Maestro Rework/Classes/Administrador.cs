using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class Administrador : Usuario
    {
        public Administrador()
        {
                
        }
        public Administrador(string login, string nome, string senha, string email)
        {
            if (string.IsNullOrWhiteSpace(login)) throw new ArgumentNullException(nameof(login));
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException(nameof(nome));
            if (string.IsNullOrWhiteSpace(senha)) throw new ArgumentNullException(nameof(senha));
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentNullException(nameof(email));

            Login = login;
            Nome = nome;
            Senha = senha;
            Email = email;        
            Nivel = 3;
            CodigoSenha = null;
            Cargo = "Administrador";
            DataCriacao = DateTime.Now;
            Ativo = true;
            Verificado = false;
        }
    }
}
