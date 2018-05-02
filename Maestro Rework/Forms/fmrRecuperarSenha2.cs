using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.Classes.Entidades;
using Maestro_Rework.DAO;

namespace Maestro_Rework.Forms
{
    public partial class fmrRecuperarSenha2 : Form
    {
        Usuario usuario;
        public fmrRecuperarSenha2(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            FormBorderStyle = FormBorderStyle.None;
            AcceptButton = btnAlterar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var usuarioDAO = new UsuarioDAO();
            RemoverCodigoDeRecuperacaoAntigo(usuarioDAO);
            fmrLogin formLogin = (fmrLogin)ActiveForm;
            formLogin.MostrarElementosDoFormLogin();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuarioDAO = new UsuarioDAO();

                if (txtSenha.Text == txtConfimarSenha.Text)
                {
                    AlterarSenhaNoBanco(usuarioDAO);
                    RemoverCodigoDeRecuperacaoAntigo(usuarioDAO);
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void RemoverCodigoDeRecuperacaoAntigo(UsuarioDAO usuarioDAO)
        {
            usuario.CodigoSenha = null;
            usuarioDAO.Atualizar(usuario);
        }

        private void AlterarSenhaNoBanco(UsuarioDAO usuarioDAO)
        {
            this.usuario.AtualizarSenha(txtSenha.Text);
            usuarioDAO.Atualizar(usuario);
        }
    }
}
