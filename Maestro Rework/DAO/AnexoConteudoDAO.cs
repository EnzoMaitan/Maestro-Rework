using Maestro_Rework.Classes;
using Maestro_Rework.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.DAO
{
    class AnexoConteudoDAO : IDisposable, IAnexoConteudoDAO
    {
        private MaestroContext contexto;

        public AnexoConteudoDAO()
        {
            contexto = new MaestroContext();
        }

        public void Adicionar(AnexoConteudo anexoConteudo)
        {
            contexto.AnexoConteudos.Add(anexoConteudo);
            contexto.SaveChanges();
        }

        public void Atualizar(AnexoConteudo anexoConteudo)
        {
            contexto.AnexoConteudos.Update(anexoConteudo);
            contexto.SaveChanges();
        }

        public IList<AnexoConteudo> AnexoConteudos() => contexto.AnexoConteudos.ToList();

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}

