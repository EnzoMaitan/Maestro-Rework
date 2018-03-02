using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.DAO;
using Maestro_Rework.Classes.Construtores;

namespace Maestro_Rework.Forms
{
    public partial class fmrAdicionarConteudo : Form
    {
        public fmrAdicionarConteudo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            lblErro.Visible = false;
            lblConteudo.Visible = false;
            cboSelecionar.Visible = false;
            lblConteudoAdicionado.Visible = false;
            AlterarVisibilidadePrazo(false);
        }

        private void chkAdicionarPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdicionarPrazo.Checked)
            {
                AlterarVisibilidadePrazo(true);
            }
            else
            {
                AlterarVisibilidadePrazo(false);
            }
        }

        private void AlterarVisibilidadePrazo(bool visibilidade)
        {
            lblFim.Visible = visibilidade;
            lblInicio.Visible = visibilidade;
            dtpFim.Visible = visibilidade;
            dtpInicio.Visible = visibilidade;
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            lblConteudoAdicionado.Visible = false;
            txtCodigo.Text = null;

            try
            {
                CheckarCamposPreenchidos();

                    var construtorConteudo = new ConteudoConstrutor();

                    construtorConteudo.ParaNome(txtNome.Text)
                        .ParaTema(cboTema.Text)
                        .ParaAtivo(true)
                        .ParaTexto(rtfTexto.Text)
                        .ParaUsuario(fmrLogin.usuarioLogado);

                    if (chkAdicionarPrazo.Checked)
                    {
                        construtorConteudo
                            .ParaDataFim(dtpFim.Value)
                            .ParaDataInicio(dtpInicio.Value);
                    }
                    else
                    {
                        construtorConteudo
                            .ParaDataFim(null)
                            .ParaDataInicio(null);
                    }
                    var usuario = construtorConteudo.Constroi();
                    var conteudoDAO = new ConteudoDAO();
                    conteudoDAO.Adicionar(usuario);

                    lblConteudoAdicionado.Visible = true;
                    txtCodigo.Text = construtorConteudo.CodigoAcesso;              
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }

        private void CheckarCamposPreenchidos()
        {
            if (txtNome.Text == "" ||
               rtfTexto.Text == "" ||
               cboTema.Text == "") throw new ArgumentNullException("","Preencha Todos os campos obrigatórios");
        }
    }
}
