using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class Questionario
    {
        public Questionario(Usuario usuario, string nome, DateTime? dataInicio, DateTime? dataFim, string codigoAcesso, bool refazer, bool ativo)
        {
            Usuario = usuario;
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            CodigoAcesso = codigoAcesso;
            Refazer = refazer;
            DataCriacao = DateTime.Now;
            Ativo = ativo;
        }
        public Questionario()
        {
                
        }

        public int Id { get; private set; }
        public int UsuarioId { get; private set; }

        public Usuario Usuario { get; private set; }
        public string Nome { get; private set; }
        public DateTime? DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }
        public string CodigoAcesso { get; private set; }
        public bool Refazer { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public bool Ativo { get; private set; }

        public IList<RegistraQuestionario> Registro { get; private set; }
        public IList<Questao> Questoes { get; private set; }
    }
}
