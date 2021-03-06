﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class Alternativa
    {
        public Alternativa(int questaoID, string texto, bool correta)
        {
            if (string.IsNullOrWhiteSpace(texto))
                throw new ArgumentNullException("", "Preencha o campo da Alternativa");
            QuestaoID = questaoID;
            Texto = texto;
            Correta = correta;
        }

        public Alternativa() { }

        public int Id { get; private set; }
        public Questao Questao { get; private set; }
        public int QuestaoID { get; private set; }
        public string Texto { get; private set; }
        public bool Correta { get; private set; }

        public void AlterarTexto(string novoTexto)
        {
            Texto = novoTexto;
        }
        public void AlterarCorreta(bool novaCorreta)
        {
            Correta = novaCorreta;
        }
    }
}
