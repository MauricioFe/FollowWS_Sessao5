namespace Sessao5
{
    partial class FrmRecuperarSenha
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.cboTimeFavorito = new System.Windows.Forms.ComboBox();
            this.selecoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessao05DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessao05DataSet = new Sessao5.Sessao05DataSet();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmacao = new System.Windows.Forms.TextBox();
            this.lblForcaSenha = new System.Windows.Forms.Label();
            this.lblSenhasIdenticas = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.selecoesTableAdapter = new Sessao5.Sessao05DataSetTableAdapters.SelecoesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.selecoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessao05DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessao05DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Favorito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmação de senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nova senha";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(312, 78);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(242, 30);
            this.dtpDataNascimento.TabIndex = 4;
            // 
            // cboTimeFavorito
            // 
            this.cboTimeFavorito.DataSource = this.selecoesBindingSource;
            this.cboTimeFavorito.DisplayMember = "Nome";
            this.cboTimeFavorito.FormattingEnabled = true;
            this.cboTimeFavorito.Location = new System.Drawing.Point(312, 117);
            this.cboTimeFavorito.Name = "cboTimeFavorito";
            this.cboTimeFavorito.Size = new System.Drawing.Size(242, 30);
            this.cboTimeFavorito.TabIndex = 5;
            this.cboTimeFavorito.ValueMember = "Id";
            this.cboTimeFavorito.SelectionChangeCommitted += new System.EventHandler(this.cboTimeFavorito_SelectionChangeCommitted);
            this.cboTimeFavorito.Leave += new System.EventHandler(this.cboTimeFavorito_Leave);
            // 
            // selecoesBindingSource
            // 
            this.selecoesBindingSource.DataMember = "Selecoes";
            this.selecoesBindingSource.DataSource = this.sessao05DataSetBindingSource;
            // 
            // sessao05DataSetBindingSource
            // 
            this.sessao05DataSetBindingSource.DataSource = this.sessao05DataSet;
            this.sessao05DataSetBindingSource.Position = 0;
            // 
            // sessao05DataSet
            // 
            this.sessao05DataSet.DataSetName = "Sessao05DataSet";
            this.sessao05DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(312, 153);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(242, 30);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtConfirmacao
            // 
            this.txtConfirmacao.Enabled = false;
            this.txtConfirmacao.Location = new System.Drawing.Point(312, 188);
            this.txtConfirmacao.MaxLength = 15;
            this.txtConfirmacao.Name = "txtConfirmacao";
            this.txtConfirmacao.Size = new System.Drawing.Size(242, 30);
            this.txtConfirmacao.TabIndex = 7;
            this.txtConfirmacao.UseSystemPasswordChar = true;
            this.txtConfirmacao.Leave += new System.EventHandler(this.txtConfirmacao_Leave);
            // 
            // lblForcaSenha
            // 
            this.lblForcaSenha.Location = new System.Drawing.Point(560, 156);
            this.lblForcaSenha.Name = "lblForcaSenha";
            this.lblForcaSenha.Size = new System.Drawing.Size(202, 20);
            this.lblForcaSenha.TabIndex = 8;
            this.lblForcaSenha.Text = "label5";
            this.lblForcaSenha.Visible = false;
            // 
            // lblSenhasIdenticas
            // 
            this.lblSenhasIdenticas.Location = new System.Drawing.Point(560, 188);
            this.lblSenhasIdenticas.Name = "lblSenhasIdenticas";
            this.lblSenhasIdenticas.Size = new System.Drawing.Size(202, 20);
            this.lblSenhasIdenticas.TabIndex = 9;
            this.lblSenhasIdenticas.Text = "label6";
            this.lblSenhasIdenticas.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.btnEntrar.Enabled = false;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntrar.Location = new System.Drawing.Point(366, 244);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(188, 29);
            this.btnEntrar.TabIndex = 10;
            this.btnEntrar.Text = "Alterar senha";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(433, 294);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 22);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // selecoesTableAdapter
            // 
            this.selecoesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRecuperarSenha
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(774, 346);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSenhasIdenticas);
            this.Controls.Add(this.lblForcaSenha);
            this.Controls.Add(this.txtConfirmacao);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.cboTimeFavorito);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Helvetica-Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Senha";
            this.Load += new System.EventHandler(this.FrmRecuperarSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selecoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessao05DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessao05DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.ComboBox cboTimeFavorito;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmacao;
        private System.Windows.Forms.Label lblForcaSenha;
        private System.Windows.Forms.Label lblSenhasIdenticas;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.BindingSource sessao05DataSetBindingSource;
        private Sessao05DataSet sessao05DataSet;
        private System.Windows.Forms.BindingSource selecoesBindingSource;
        private Sessao05DataSetTableAdapters.SelecoesTableAdapter selecoesTableAdapter;
    }
}