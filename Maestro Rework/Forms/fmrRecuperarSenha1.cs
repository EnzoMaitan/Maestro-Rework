using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.Classes;
using Maestro_Rework.Classes.Entidades;
using Maestro_Rework.DAO;

namespace Maestro_Rework.Forms
{
    public partial class fmrRecuperarSenha1 : Form
    {
        public fmrRecuperarSenha1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            lblErro.Visible = false;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = PesquisarUsuarioPorEmail(txtEmail.Text);

                if (txtCodigo.Text == usuario.CodigoSenha)
                {
                    MostrarFormularioDeAlterarSenha(usuario);
                }
                else throw new ArgumentException("O Codigo não é valido");
            }
            catch (ArgumentException ex)
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro,ex);
            }
        }

        private Usuario PesquisarUsuarioPorEmail(string email)
        {
            using (var contexto = new MaestroContext())
            {
                var query = contexto.Usuarios.Where(x => x.Email == email);
                if (query.FirstOrDefault() != null)
                    return query.FirstOrDefault();
                else throw new ArgumentException("Email Invalido");
            }
        }
        private void MostrarFormularioDeAlterarSenha(Usuario usuario)
        {
            var show = new fmrRecuperarSenha2(usuario);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fmrLogin formLogin = (fmrLogin)ActiveForm;
            formLogin.MostrarElementosDoFormLogin();
            Close();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                EnviadorDeEmail.EnviarEmailDeRecuperacaoDeSenha(txtEmail.Text);
            }
            catch (SmtpException ex)
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
            }
        }
    }
}
