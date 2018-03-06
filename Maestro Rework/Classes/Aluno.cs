using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class Aluno : Usuario
    {
        public Aluno()
        {
                
        }
        public Aluno(string login, string nome, string senha, string email)
        {
            Login = login;
            Nome = nome;
            Senha = senha;
            Email = email;
            Nivel = 1;
            CodigoSenha = null;
            Cargo = "Aluno";
            DataCriacao = DateTime.Now;
            Ativo = true;
            Verificado = false;
        }
    }
}
