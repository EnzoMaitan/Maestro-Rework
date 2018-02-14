using System;
using System.Windows.Forms;
using Maestro_Rework.Classes.Construtores;
using Maestro_Rework.DAO;

namespace Maestro_Rework.Forms
{
    public partial class UsuarioCadastro : Form
    {
        public UsuarioCadastro()
        {
            InitializeComponent();
        }

        private void BtnAcao_Click(object sender, EventArgs e)
        {
            using (var contexto = new MaestroContext())
            {
                var usuarioDao = new UsuarioDAO();
                var builder = new UsuarioConstrutor();

                var usuario = builder.ParaNome("Nome")
                       .ParaLogin("Login")
                       .ParaSenha("Senha")
                       .ParaCargo("Cargo")
                       .ParaNivel(1)
                       .ParaCodigoSenha(null)
                       .ParaEmail("Email")
                       .Constroi();

                usuarioDao.Adicionar(usuario);

            }
        }
    }
}
