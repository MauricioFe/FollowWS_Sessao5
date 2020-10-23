using Sessao5.models;
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
        Usuario usuario;
        public FrmRecuperarSenha(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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
            dtpDataNascimento.Value = usuario.Nascimento.Date;
            cboTimeFavorito.SelectedValue = usuario.TimeFavoritoId;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmacao.Text)
            {
                //alterar senha
            }
            else
            {
                MessageBox.Show("as senha precisam ser iguais");
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("");
        }
    }
}
