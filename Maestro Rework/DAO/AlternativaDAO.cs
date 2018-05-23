using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Entidades;
using Maestro_Rework.IDAO;

namespace Maestro_Rework.DAO
{
    class AlternativaDAO : IAlternativaDAO
    {
        private MaestroContext contexto;

        public AlternativaDAO()
        {
            contexto = new MaestroContext();
        }
        public void Adicionar(Alternativa alternativa)
        {
            contexto.Alternativas.Add(alternativa);
            contexto.SaveChanges();
        }

        public IList<Alternativa> Alternativas() => contexto.Alternativas.ToList();

        public void Atualizar(Alternativa alternativa)
        {
            contexto.Alternativas.Update(alternativa);
            contexto.SaveChanges();
        }
    }
}
