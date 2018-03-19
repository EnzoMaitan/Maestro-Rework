using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Maestro_Rework.Classes;
using Maestro_Rework.Classes.Construtores;
namespace Maestro_Rework.UnitTests
{
    [TestFixture]
    public class QuestionarioTests
    {
        [Test]
        public void CheckarLimitePrazo_DataLimiteAntesDaDataDeInicio_ThrowExpection()
        {
            var questionarioConstrutor = new QuestionarioConstrutor();
                questionarioConstrutor
                .ParaRefazer(false)
                .ParaAtivo(false)
                .ParaDataFim(DateTime.MinValue)
                .ParaDataInicio(DateTime.MaxValue);

            Assert.That(() => questionarioConstrutor.Constroi(), Throws.Exception);
        }
        [Test]
        public void CheckarLimitePrazo_NaoPossuiPrazo_PrazoNull()
        {
            var questionarioConstrutor = new QuestionarioConstrutor();
            var questionario = questionarioConstrutor
                .ParaAtivo(false)
                .ParaRefazer(false)
                .ParaDataFim(null)
                .ParaDataInicio(null)
                .Constroi();

            Assert.IsNull(questionario.DataFim);
            Assert.IsNull(questionario.DataInicio);
        }
    }
}
