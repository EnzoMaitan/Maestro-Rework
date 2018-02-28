﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Construtores
{
    class QuestionarioConstrutor
    {
        public int UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public DateTime? DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }
        public string CodigoAcesso { get; private set; }
        public bool Refazer { get; private set; }
        public bool Ativo { get; private set; }
        public IList<Questao> Questoes { get; private set; }
        public QuestionarioConstrutor ParaUsuario(Usuario usuario)
        {
            UsuarioId = usuario.Id;
            return this;
        }
        public QuestionarioConstrutor ParaNome(string nome)
        {
            Nome = nome;
            return this;
        }
        public QuestionarioConstrutor ParaDataInicio(DateTime? dataInicio)
        {
            DataInicio = dataInicio;
            return this;
        }
        public QuestionarioConstrutor ParaDataFim(DateTime? dataFim)
        {
            DataFim = dataFim;
            return this;
        }
        public QuestionarioConstrutor ParaRefazer(bool refazer)
        {
            Refazer = refazer;
            return this;
        }
        public QuestionarioConstrutor ParaAtivo(bool ativo)
        {
            Ativo = ativo;
            return this;
        }
        public QuestionarioConstrutor ParaQuestoes(IList<Questao> questoes)
        {
            Questoes = questoes;
            return this;
        }

        public Questionario Constroi()
        {
            CodigoAcesso = GeradorDeCodigo.GerarCodigoAcesso();
            return new Questionario(UsuarioId, Nome, DataInicio, DataFim, CodigoAcesso, Refazer, Ativo);
        }
    }
}