using Sessao5.models;
using Sessao5.Sessao05DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using static Sessao5.Sessao05DataSet;

namespace Sessao5
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void llbEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsuariosTableAdapter usuarioAdapter = new UsuariosTableAdapter();
            int emailValido = usuarioAdapter.FillEmailExiste(sessao05DataSet1.Usuarios, txtEmail.Text);
            if (txtEmail.Text != "" && emailValido > 0)
            {
                FrmRecuperarSenha form = new FrmRecuperarSenha(txtEmail.Text);
                form.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Digite um endereço de email válido");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}
