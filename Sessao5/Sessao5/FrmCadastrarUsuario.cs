using Sessao5.Sessao05DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        string sexo = "M";
        List<bool> validacoes = new List<bool>();
        UsuariosTableAdapter usuariosAdapter = new UsuariosTableAdapter();
        UsuariosDataTable usuariosDt = new UsuariosDataTable();
        FrmRecuperarSenha form = new FrmRecuperarSenha();

        public FrmCadastrarUsuario()
        {
            InitializeComponent();
            btnCadastrar.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sessao05DataSet.Selecoes' table. You can move, or remove it, as needed.
            this.selecoesTableAdapter.Fill(this.sessao05DataSet.Selecoes);

        }
        public static bool ValidaEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{3,}([.\-_]?[a-zA-Z][a-zA-Z0-9]{3,})?@[a-zA-Z]{3,}\.[a-zA-Z]{2,}$");
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
                lblEmailcadastrado.Text = "Email não cadastrado";
                lblEmailcadastrado.BackColor = Color.FromArgb(217, 17, 54);
                lblEmailcadastrado.ForeColor = Color.White;
                lblEmailcadastrado.Visible = true;
            }
            ConferindoValidacoes();

        }

        private void ConferindoValidacoes()
        {
            if (ValidaEmail(txtEmail.Text) && (ValidaData(dtpDataNascimento.Value)) && ValidaNome(txtNome.Text) && ValidaEmailUnico(txtEmail.Text))
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }

        public bool ValidaNome(string nome)
        {
            Regex regex = new Regex(@"^([A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]+ [A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]+)+$");
            if (regex.IsMatch(nome))
                return true;
            return false;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (!ValidaNome(((TextBox)sender).Text))
            {
                MessageBox.Show("Esse campo precisa que tenha no mínimo dois nomes");
            }
            ConferindoValidacoes();

        }
        private bool ValidaData(DateTime date)
        {
            int idade = new DateTime(DateTime.Now.Subtract(date).Ticks).Year - 1;
            if (idade < 18)
            {
                dtpDataNascimento.Value = DateTime.Now;
                return false;
            }
            return true;
        }

        private void rbtMasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "M";
        }

        private void rbtFeminino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "F";
        }

        private void linkSelecionarFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofpFile.Filter = "Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpeg|JPG files|*.jpg";
            if (ofpFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofpFile.FileName);
                MessageBox.Show("Foto selecionada com sucesso.");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            ImageConverter imagem = new ImageConverter();
            usuariosAdapter.Insert(txtNome.Text, txtEmail.Text, "admin123", dtpDataNascimento.Value, (byte[])imagem.ConvertTo(pictureBox1.Image, typeof(byte[])), sexo, Convert.ToInt32(cboTimeFavorito.SelectedValue.ToString()), "1");
            MessageBox.Show("Usuario cadastrado com sucesso.");
            this.Dispose();
        }

        private void dtpDataNascimento_Leave(object sender, EventArgs e)
        {
            if (!ValidaData(((DateTimePicker)sender).Value))
            {
                MessageBox.Show("Para ser cadastrado você precisa ter mais de 18 anos");
            }
            ConferindoValidacoes();
        }

        private void cboTimeFavorito_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ConferindoValidacoes();
        }

        private void cboTimeFavorito_Leave(object sender, EventArgs e)
        {
            ConferindoValidacoes();
        }
    }
}
