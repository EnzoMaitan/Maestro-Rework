using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Entidades;

namespace Maestro_Rework.Classes.Construtores
{
    public class ConteudoConstrutor
    {
        public int UsuarioID { get; private set; }
        public string Nome { get; private set; }
        public string Tema { get; private set; }
        public string Texto { get; private set; }

        public string CodigoAcesso { get; private set; }

        public ConteudoConstrutor ParaUsuario(Usuario usuario)
        {
            UsuarioID = usuario.Id;
            return this;
        }
        public ConteudoConstrutor ParaNome(string nome)
        {
            Nome = nome;
            return this;
        }
        public ConteudoConstrutor ParaTema(string tema)
        {
            Tema = tema;
            return this;
        }
        public ConteudoConstrutor ParaTexto(string texto)
        {
            Texto = texto;
            return this;
        }

        public Conteudo Constroi()
        {
            CodigoAcesso = GeradorDeCodigo.GerarCodigoAcesso();
                return new Conteudo(UsuarioID, Nome, Tema, Texto, CodigoAcesso);           
        }
    }
}
