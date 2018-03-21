using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Construtores
{
    public class AnexoConteudoConstrutor 
    {
        public int ConteudoID { get; private set; }
        public byte[] Anexo { get; private set; }
        public byte[] Imagem { get; private set; }
        public string Nome { get; private set; }

        public AnexoConteudoConstrutor ParaConteudo(Conteudo conteudo)
        {
            ConteudoID = conteudo.Id;
            return this;
        }
        public AnexoConteudoConstrutor ParaAnexo(byte[] anexo)
        {
            Anexo = anexo;
            return this;
        }
        public AnexoConteudoConstrutor ParaImagem(byte[] imagem)
        {
            Imagem = imagem;
            return this;
        }
        public AnexoConteudoConstrutor ParaNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public AnexoConteudo Constroi()
        {
            return new AnexoConteudo(ConteudoID, Anexo, Imagem, Nome);
        }

        internal object ParaNome(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
