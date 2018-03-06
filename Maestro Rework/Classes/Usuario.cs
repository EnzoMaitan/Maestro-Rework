using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public abstract class Usuario
    {
        public void AtualizarSenha(string senha)
        {
            Senha = senha;
        }

        public int Id { get; protected set; }
        public string Login { get; protected set; }
        public string Nome { get; protected set; }
        public string Senha { get; protected set; }
        public string Email { get; protected set; }
        public int Nivel { get; protected set; }
        public bool Ativo { get; protected set; }
        public string CodigoSenha { get; protected set; }
        public string Cargo { get; protected set; }
        public bool Verificado { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public IList<UsuarioConteudo> Conteudos { get; set; }
        public IList<RegistroUsuario> Registros { get; set; }
    }
}
