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
        int id;
        int iguais = 0;
        public FrmRecuperarSenha(string email, int id)
        {
            InitializeComponent();
            this.email = email;
            this.id = id;
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
            UsuariosTableAdapter usuarioAdapter = new UsuariosTableAdapter();
            usuarioAdapter.UpdateSenha(txtSenha.Text, id);
            FrmLogin form = new FrmLogin();
            form.Show();
            this.Dispose();
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            ValidaForcaSenha(txtSenha.Text);

        }

        private void ValidaForcaSenha(string senha)
        {
            Regex regex = new Regex("^[a-z0-9]{8,15}$");
            if (regex.IsMatch(senha) && iguais == 0)
            {
                lblForcaSenha.Text = "Alto";
                lblForcaSenha.BackColor = Color.FromArgb(3, 166, 90);
                lblForcaSenha.ForeColor = Color.White;
                lblForcaSenha.Visible = true;
            }
            else if (regex.IsMatch(txtSenha.Text) && iguais == 1)
            {
                lblForcaSenha.Text = "Médio";
                lblForcaSenha.BackColor = Color.FromArgb(242, 135, 5);
                lblForcaSenha.ForeColor = Color.White;
                lblForcaSenha.Visible = true;
            }
            else if (regex.IsMatch(txtSenha.Text) && iguais > 1)
            {
                lblForcaSenha.Text = "Baixo";
                lblForcaSenha.BackColor = Color.FromArgb(217, 17, 54);
                lblForcaSenha.ForeColor = Color.White;
                lblForcaSenha.Visible = true;
            }
            else
            {
                MessageBox.Show("Sua senha precisa ter entre 8 e 15 caracteres, Não podem ter letras maiúsculas e nem caracteres especiais");
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
                lblSenhasIdenticas.Text = "Senhas Identicas";
                lblSenhasIdenticas.BackColor = Color.FromArgb(3, 166, 90);
                lblSenhasIdenticas.ForeColor = Color.White;
                lblSenhasIdenticas.Visible = true;
                btnEntrar.Enabled = true;
            }
            else
            {
                lblSenhasIdenticas.Text = "Senhas não correspondem";
                lblSenhasIdenticas.BackColor = Color.FromArgb(217, 17, 54);
                btnEntrar.Enabled = false;
                lblSenhasIdenticas.Visible = true;
            }
        }
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = (TextBox)sender;
            if (e.KeyChar == (char)Keys.Back)
            {
                for (int i = 0; i < txtSenha.Text.Length; i++)
                {
                    if (!txt.Text.Contains(e.KeyChar.ToString()))
                    {
                        iguais--;
                        break;
                    }
                }
            }
            for (int i = 0; i < txtSenha.Text.Length; i++)
            {
                if (txt.Text.Contains(e.KeyChar.ToString()))
                {
                    iguais++;
                    break;
                }
            }
        }
    }
}
