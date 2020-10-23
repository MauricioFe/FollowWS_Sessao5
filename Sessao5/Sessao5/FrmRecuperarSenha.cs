using Sessao5.models;
using Sessao5.Sessao05DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sessao5
{
    public partial class FrmRecuperarSenha : Form
    {
        string email;
        public FrmRecuperarSenha(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Dispose();
        }

        private void FrmRecuperarSenha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sessao05DataSet.Selecoes' table. You can move, or remove it, as needed.
            this.selecoesTableAdapter.Fill(this.sessao05DataSet.Selecoes);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-z0-9]{8,15}$");
            if (regex.IsMatch(txtSenha.Text) && txtSenha.Text == txtConfirmacao.Text)
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
                MessageBox.Show("Senha inválida");
            }
        }

        private void cboTimeFavorito_Leave(object sender, EventArgs e)
        {
            ValidadandoNascimentoTime();
        }

        private void ValidadandoNascimentoTime()
        {
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            int cont = usuarios.FillByNascimentoAndTime(sessao05DataSet.Usuarios, email, dtpDataNascimento.Value.Date.ToString("yyyy-MM-dd"),
                Convert.ToInt32(cboTimeFavorito.SelectedValue));

            if (cont > 0)
            {
                txtConfirmacao.Enabled = true;
                txtSenha.Enabled = true;
            }
            else
            {
                txtConfirmacao.Enabled = false;
                txtSenha.Enabled = false;
            }
        }

        private void cboTimeFavorito_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ValidadandoNascimentoTime();
        }

        private void txtConfirmacao_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-z0-9]{8,15}$");
            if (regex.IsMatch(txtSenha.Text) && txtSenha.Text == txtConfirmacao.Text)
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
                MessageBox.Show("Senha inválida");
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
    }
}
