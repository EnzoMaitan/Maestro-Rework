using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes
{
    public class AnexoConteudo
    {
        public AnexoConteudo(int conteudoID, byte[] anexo, byte[] imagem, string nome)
        {
            ConteudoID = conteudoID;
            Anexo = anexo;
            Imagem = imagem;
            Nome = nome;
        }
        
        public Conteudo Conteudo { get; private set; }
        public int Id { get; private set; }
        public int ConteudoID { get; private set; }
        public byte[] Anexo { get; private set; }
        public byte[] Imagem { get; private set; }
        public string Nome { get; private set; }
    }
}
