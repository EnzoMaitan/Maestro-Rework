﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class Conteudo
    {
        public Conteudo(Usuario usuario, string nome, string tema, string texto, DateTime dataInicio, DateTime dataFim, string codigoAcesso, bool ativo)
        {
            Usuario = usuario;
            Nome = nome;
            Tema = tema;
            Texto = texto;
            DataInicio = dataInicio;
            DataFim = dataFim;
            CodigoAcesso = codigoAcesso;
            Ativo = ativo;
            DataCriacao = DateTime.Now;
        }
        public Conteudo()
        {

        }

        public int Id { get; private set; }
        public int UsuarioID { get; private set; }
        public IList<UsuarioConteudo> Usuarios { get; set; }
        public IList<RegistroConteudo> Registros { get; set; }
        public IList<AnexoConteudo> Anexos { get; private set; }
        public Usuario Usuario { get; private set; }
        public string Nome { get; private set; }
        public string Tema { get; private set; }
        public string Texto { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public string CodigoAcesso { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCriacao { get; private set; }
    }
}
