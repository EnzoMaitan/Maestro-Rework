using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class Questionario
    {
        public Questionario(int usuarioId, string nome, DateTime? dataInicio, DateTime? dataFim, string codigoAcesso, bool refazer, bool ativo, IList<Questao> questoes)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;          
            CodigoAcesso = codigoAcesso;
            Refazer = refazer;
            DataCriacao = DateTime.Now;
            Ativo = ativo;
            Questoes = questoes;

            if (!CheckarLimitePrazo()) throw new ArgumentException("A data limite deve ser após a data de inicio");
        }

        private bool CheckarLimitePrazo()
        {
            bool possuiPrazo = DataInicio != null && DataFim != null;

            if (possuiPrazo)
            {
                if (DataInicio.Value < DataFim.Value) return true;
                else return false;
            }
            else return true;
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

        public double GetTotalDePontos()
        {
            double totalDePontos = 0.0;
            foreach (var questao in Questoes)
            {
                totalDePontos = questao.Valor + totalDePontos;
            }
            return totalDePontos;
        }
    }
}
