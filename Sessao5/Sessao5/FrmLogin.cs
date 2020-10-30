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
        int id = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void llbEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsuariosTableAdapter usuarioAdapter = new UsuariosTableAdapter();
            UsuariosDataTable usuarioDt = usuarioAdapter.GetEmailExiste(txtEmail.Text);
            foreach (var item in usuarioDt)
            {
                id = Convert.ToInt32(item["id"]);
            }
            int emailValido = usuarioAdapter.FillEmailExiste(sessao05DataSet1.Usuarios, txtEmail.Text);
            if (txtEmail.Text != "" && emailValido > 0)
            {
                FrmRecuperarSenha form = new FrmRecuperarSenha(txtEmail.Text, id);
                form.Show();
                this.Hide();
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
            UsuariosTableAdapter usuarioAdapter = new UsuariosTableAdapter();
            UsuariosDataTable usuarioDt = usuarioAdapter.GetLogin(txtEmail.Text, txtSenha.Text);
            Usuario usuario = new Usuario();
            foreach (var item in usuarioDt)
            {
                usuario.Id = Convert.ToInt32(item["id"]);
                usuario.Nome = item["Nome"].ToString();
                usuario.Email = item["Email"].ToString();
                usuario.Senha = item["Senha"].ToString();
                usuario.Sexo = item["Sexo"].ToString();
                usuario.perfil = item["Perfil"].ToString();
                usuario.Nascimento = Convert.ToDateTime(item["Nascimento"]);
                usuario.Foto = (byte[])(item["foto"] == DBNull.Value ? null : item["foto"]);
                usuario.TimeFavoritoId = Convert.ToInt32(item["timeFavoritoId"]);
            }
            int numRegistros = usuarioAdapter.FillLogin(sessao05DataSet1.Usuarios, txtEmail.Text, txtSenha.Text);
            if (txtEmail.Text != "" && txtSenha.Text != "")
            {
                if (usuario.perfil == "1" && numRegistros > 0)
                {
                    MessageBox.Show("Login feito para usuario");
                }
                else if (usuario.perfil == "0" && numRegistros > 0)
                {
                    MessageBox.Show("Login feito para adm");
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha errados");
                }
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha bazios");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastrarUsuario form = new FrmCadastrarUsuario();
            form.ShowDialog();
        }
    }
}
