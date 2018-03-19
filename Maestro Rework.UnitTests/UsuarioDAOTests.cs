using NUnit.Framework;
using Maestro_Rework.DAO;

namespace Maestro_Rework.UnitTests
{
    [TestFixture]
    public class UsuarioDAOTests
    {
        private UsuarioDAO _usuarioDAO;

        [SetUp]
        public void SetUp()
        {
           _usuarioDAO = new UsuarioDAO();
        }

        [Test]
        public void LoginDisponivel_LoginInexistente_RetornaTrue()
        {
            var resultado = _usuarioDAO.LoginDisponivel("NOMEQUENAOESTAEMUSO");

            Assert.IsTrue(resultado);
        }

        [Test]
        public void LoginDisponivel_LoginEmUso_ThrowException()
        {
            Assert.That(() => _usuarioDAO.LoginDisponivel("q"), Throws.Exception);
        }

        [Test]
        public void ValidarLogin_LoginValido_RetornaTrue()
        {
            var resultado = _usuarioDAO.ValidarLogin("q", "q");

            Assert.IsTrue(resultado);
        }

        [Test]
        public void ValidarLogin_LoginInvalido_ThrowException()
        {
            Assert.That(
                () => _usuarioDAO.ValidarLogin("LOGINERRADO", "SENHAERRADA")
                , Throws.Exception);
        }
    }
}
