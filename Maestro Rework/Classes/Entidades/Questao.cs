﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class Questao
    {
        public Questao(int questionarioID, IList<Alternativa> alternativas, string pergunta, double valor, byte[] imagem)
        {
            if (string.IsNullOrWhiteSpace(pergunta))
                throw new ArgumentNullException("","Preencha o campo da Pergunta");
            if (valor <= 0)
                throw new ArgumentOutOfRangeException("Valor da Questão", "Selecione o peso da questão");

            QuestionarioID = questionarioID;
            Alternativas = alternativas;
            Pergunta = pergunta;
            Valor = valor;
            Imagem = imagem;
        }
        public Questao()
        {

        }
        public int Id { get; private set; }
        public Questionario Questionario { get; private set; }
        public int QuestionarioID { get; private set; }
        public IList<Alternativa> Alternativas { get; private set; }
        public string Pergunta { get; private set; }
        public double Valor { get; private set; }
        public byte[] Imagem { get; private set; }

        public void AlterarPergunta(string novaPergunta)
        {
            Pergunta = novaPergunta;
        }

        public void AlterarValor(double novoValor)
        {
            Valor = novoValor;
        }
        public void AlterarImagem(byte[] novaImagem)
        {
            Imagem = novaImagem;
        }
        public override string ToString()
        {
            return Pergunta;
        }
    }
}
