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
using static Sessao5.Sessao05DataSet;

namespace Sessao5
{
    public partial class FrmCadastrarUsuario : Form
    {
        UsuariosTableAdapter usuariosAdapter = new UsuariosTableAdapter();
        UsuariosDataTable usuariosDt = new UsuariosDataTable();
        FrmRecuperarSenha form = new FrmRecuperarSenha();

        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Dispose();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sessao05DataSet.Selecoes' table. You can move, or remove it, as needed.
            this.selecoesTableAdapter.Fill(this.sessao05DataSet.Selecoes);

        }



        public static bool ValidaEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{3,}[.\-_]?[a-zA-Z][a-zA-Z0-9]{3,}@[a-zA-Z]{3,}\.[a-zA-Z]{2,}$");
            if (regex.IsMatch(email))
            {
                return true;
            }
            return false;
        }
        public bool ValidaEmailUnico(string email)
        {
            int cont = usuariosAdapter.FillEmailExiste(sessao05DataSet.Usuarios, email);
            if (cont > 0)
            {
                return false;
            }
            return true;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidaEmail(txtEmail.Text))
            {
                MessageBox.Show("Digite um email válido");
            }
            if (!ValidaEmailUnico(txtEmail.Text))
            {
                lblEmailcadastrado.Text = "Email cadastrado";
                lblEmailcadastrado.BackColor = Color.FromArgb(217, 17, 54);
                lblEmailcadastrado.ForeColor = Color.White;
                lblEmailcadastrado.Visible = true;
            }
            else
            {
                lblEmailcadastrado.Visible = false;
            }

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            form.ValidaForcaSenha(txtSenha.Text);
        }

        private void txtConfirmacao_Leave(object sender, EventArgs e)
        {
            form.ValidarConfirmacaoSenha(txtSenha.Text, txtConfirmacao.Text);
        }
    }
}
