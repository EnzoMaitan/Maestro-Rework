using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;

namespace Maestro_Rework.Classes.Construtores
{
    class QuestaoConstrutor
    {
        public int QuestionarioID { get; private set; }
        public IList<Alternativa> Alternativas { get; private set; }
        public string Pergunta { get; private set; }
        public double Valor { get; private set; }
        public byte[] Imagem { get; private set; }

        public QuestaoConstrutor ParaQuestionario(Questionario questionario)
        {
            QuestionarioID = questionario.Id;
            return this;
        }

        public QuestaoConstrutor ParaPergunta(string pergunta)
        {
            Pergunta = pergunta;
            return this;
        }

        public QuestaoConstrutor ParaValor(double valor)
        {
            Valor = valor;
            return this;
        }

        public QuestaoConstrutor ParaImagem(byte[] imagem)
        {
            Imagem = imagem;
            return this;
        }

        public QuestaoConstrutor ParaAlternativas(IList<Alternativa> alternativas)
        {
            Alternativas = alternativas;
            return this;
        }

        public Questao Constroi()
        {
            return new Questao(QuestionarioID, Alternativas, Pergunta, Valor, Imagem);
        }
    }
}
