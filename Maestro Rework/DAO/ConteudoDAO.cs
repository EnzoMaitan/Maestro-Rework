using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;
using Maestro_Rework.IDAO;

namespace Maestro_Rework.DAO
{
    class ConteudoDAO : IDisposable, IConteudoDAO
    {
        private MaestroContext contexto;

        public ConteudoDAO()
        {
            contexto = new MaestroContext();
        }

        public void Adicionar(Conteudo conteudo)
        {
            contexto.Conteudos.Add(conteudo);
            contexto.SaveChanges();
        }

        public void Atualizar(Conteudo conteudo)
        {
            contexto.Conteudos.Update(conteudo);
            contexto.SaveChanges();
        }

        public IList<Conteudo> Conteudo() => contexto.Conteudos.ToList();

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
