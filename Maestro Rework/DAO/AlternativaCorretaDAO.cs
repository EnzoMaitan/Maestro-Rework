using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.IDAO;
using Maestro_Rework.Classes.Entidades;

namespace Maestro_Rework.DAO
{
    class AlternativaCorretaDAO : IAlternativaCorretaDAO
    {
        private MaestroContext contexto;

        public AlternativaCorretaDAO()
        {
            contexto = new MaestroContext();
        }
        public void Adicionar(AlternativaCorreta alternativaCorreta)
        {
            contexto.AlternativaCorretas.Add(alternativaCorreta);
            contexto.SaveChanges();
        }

        public IList<AlternativaCorreta> alternativaCorretas() => contexto.AlternativaCorretas.ToList();


        public void Atualizar(AlternativaCorreta alternativaCorreta)
        {
            contexto.AlternativaCorretas.Update(alternativaCorreta);
            contexto.SaveChanges();
        }
    }
}
