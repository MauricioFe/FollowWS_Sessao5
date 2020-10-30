namespace Sessao5
{
    partial class FrmCadastrarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkSelecionarFoto = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmailcadastrado = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.cboTimeFavorito = new System.Windows.Forms.ComboBox();
            this.selecoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessao05DataSet = new Sessao5.Sessao05DataSet();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ofpFile = new System.Windows.Forms.OpenFileDialog();
            this.selecoesTableAdapter = new Sessao5.Sessao05DataSetTableAdapters.SelecoesTableAdapter();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selecoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessao05DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica-Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(694, 385);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 22);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkSelecionarFoto
            // 
            this.linkSelecionarFoto.AutoSize = true;
            this.linkSelecionarFoto.Location = new System.Drawing.Point(760, 385);
            this.linkSelecionarFoto.Name = "linkSelecionarFoto";
            this.linkSelecionarFoto.Size = new System.Drawing.Size(123, 22);
            this.linkSelecionarFoto.TabIndex = 21;
            this.linkSelecionarFoto.TabStop = true;
            this.linkSelecionarFoto.Text = "Selecionar Foto";
            this.linkSelecionarFoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelecionarFoto_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmailcadastrado);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(17, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 117);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // lblEmailcadastrado
            // 
            this.lblEmailcadastrado.Location = new System.Drawing.Point(453, 50);
            this.lblEmailcadastrado.Name = "lblEmailcadastrado";
            this.lblEmailcadastrado.Size = new System.Drawing.Size(192, 20);
            this.lblEmailcadastrado.TabIndex = 25;
            this.lblEmailcadastrado.Text = "label5";
            this.lblEmailcadastrado.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 30);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtFeminino);
            this.groupBox2.Controls.Add(this.rbtMasculino);
            this.groupBox2.Controls.Add(this.cboTimeFavorito);
            this.groupBox2.Controls.Add(this.dtpDataNascimento);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 186);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(540, 110);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(95, 26);
            this.rbtFeminino.TabIndex = 28;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            this.rbtFeminino.CheckedChanged += new System.EventHandler(this.rbtFeminino_CheckedChanged);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(433, 110);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(101, 26);
            this.rbtMasculino.TabIndex = 27;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.rbtMasculino_CheckedChanged);
            // 
            // cboTimeFavorito
            // 
            this.cboTimeFavorito.DataSource = this.selecoesBindingSource;
            this.cboTimeFavorito.DisplayMember = "Nome";
            this.cboTimeFavorito.FormattingEnabled = true;
            this.cboTimeFavorito.Location = new System.Drawing.Point(128, 140);
            this.cboTimeFavorito.Name = "cboTimeFavorito";
            this.cboTimeFavorito.Size = new System.Drawing.Size(286, 30);
            this.cboTimeFavorito.TabIndex = 26;
            this.cboTimeFavorito.ValueMember = "Id";
            // 
            // selecoesBindingSource
            // 
            this.selecoesBindingSource.DataMember = "Selecoes";
            this.selecoesBindingSource.DataSource = this.sessao05DataSet;
            // 
            // sessao05DataSet
            // 
            this.sessao05DataSet.DataSetName = "Sessao05DataSet";
            this.sessao05DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(172, 77);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(242, 30);
            this.dtpDataNascimento.TabIndex = 25;
            this.dtpDataNascimento.ValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(493, 30);
            this.txtNome.TabIndex = 24;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nome completo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Data de nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Time Favorito";
            // 
            // ofpFile
            // 
            this.ofpFile.FileName = "openFileDialog1";
            this.ofpFile.Title = "Escolha uma foto sua";
            // 
            // selecoesTableAdapter
            // 
            this.selecoesTableAdapter.ClearBeforeFill = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(17, 379);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 28);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(694, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 132);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCadastrarUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(895, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkSelecionarFoto);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Helvetica-Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuario";
            this.Load += new System.EventHandler(this.FrmCadastrarUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selecoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessao05DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkSelecionarFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.ComboBox cboTimeFavorito;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ofpFile;
        private System.Windows.Forms.Label lblEmailcadastrado;
        private Sessao05DataSet sessao05DataSet;
        private System.Windows.Forms.BindingSource selecoesBindingSource;
        private Sessao05DataSetTableAdapters.SelecoesTableAdapter selecoesTableAdapter;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}