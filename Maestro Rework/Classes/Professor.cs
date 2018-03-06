using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class Professor : Usuario
    {
        public Professor()
        {
                
        }
        public Professor(string login, string nome, string senha, string email)
        {
            Login = login;
            Nome = nome;
            Senha = senha;
            Email = email;
            Nivel = 2;
            CodigoSenha = null;
            Cargo = "Professor";
            DataCriacao = DateTime.Now;
            Ativo = true;
            Verificado = false;
        }
    }
}
