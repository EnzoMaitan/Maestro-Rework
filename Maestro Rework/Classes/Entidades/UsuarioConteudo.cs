using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.DAO;

namespace Maestro_Rework.Classes.Entidades
{
    public class UsuarioConteudo
    {
        public Usuario Usuario { get; private set; }
        public int UsuarioID { get; private set; }
        public Conteudo Conteudo { get; private set; }
        public int ConteudoID { get; private set; }
        public bool Acesso { get; private set; }

        public UsuarioConteudo() { }

        public UsuarioConteudo(Usuario usuario, string codigoDoConteudo)
        {
            this.UsuarioID = usuario.Id;
            var conteudoDAO = new ConteudoDAO();
            var conteudo = conteudoDAO.Conteudo().FirstOrDefault(x => x.CodigoAcesso == codigoDoConteudo.ToUpper());
            if (conteudo != null)
            {
                this.ConteudoID = conteudo.Id;
            }
            else
                throw new ArgumentException("", "Código de acesso invalido");
        }

        public void DestravarConteudo()
        {
            this.Acesso = true;
            var usuarioConteudoDAO = new UsuarioConteudoDAO();
            usuarioConteudoDAO.Adicionar(this);
        }
    }
}
