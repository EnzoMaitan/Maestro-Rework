using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes;

namespace Maestro_Rework.UnitTests
{
    [TestFixture]
    public class UsuarioTests
    {
        [Test]
        public void CheckarEmailConfirmado_EmailNaoConfirmado_ThrowException()
        {
            var usuario = new Aluno();

            Assert.That(() => usuario.CheckarEmailConfirmado(), Throws.Exception);
        }
    }
}
