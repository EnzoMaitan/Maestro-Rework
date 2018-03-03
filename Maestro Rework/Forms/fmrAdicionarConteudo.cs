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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
                    var conteudoDAO = new ConteudoDAO();

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
                    var conteudo = construtorConteudo.Constroi();
                    
                    conteudoDAO.Adicionar(conteudo);

                    lblConteudoAdicionado.Visible = true;
                    txtCodigo.Text = conteudo.CodigoAcesso;

                    LimparCampos();
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            rtfTexto.Clear();
            cboTema.Text = "";
            listBox1.Items.Clear();
        }

        private void CheckarCamposPreenchidos()
        {
            if (txtNome.Text == "" ||
               rtfTexto.Text == "" ||
               cboTema.Text == "") throw new ArgumentNullException("","Preencha Todos os campos obrigatórios");
        }
    }
}
