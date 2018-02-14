using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Construtores
{
    class ConteudoConstrutor
    {
        public Usuario Usuario { get; private set; }
        public string Nome { get; private set; }
        public string Tema { get; private set; }
        public string Texto { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Ativo { get; private set; }
        public string CodigoAcesso { get; private set; }

        public ConteudoConstrutor ParaUsuario(Usuario usuario)
        {
            Usuario = usuario;
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
        public ConteudoConstrutor ParaDataInicio(DateTime dataInicio)
        {
            DataInicio = dataInicio;
            return this;
        }
        public ConteudoConstrutor ParaDataFim(DateTime dataFim)
        {
            DataFim = dataFim;
            return this;
        }

        public ConteudoConstrutor ParaAtivo(bool ativo)
        {
            Ativo = ativo;
            return this;
        }

        public Conteudo Constroi()
        {
            CodigoAcesso = GeradorDeCodigo.GerarCodigoAcesso();
            return new Conteudo(Usuario, Nome, Tema, Texto, DataInicio, DataFim, CodigoAcesso, Ativo);
        }
    }
}
