namespace Agenda_Telefonica
{
    partial class frmCadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtTelefone = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(109, 41);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(444, 22);
            label2.Name = "label2";
            label2.Size = new Size(130, 41);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 194);
            label3.Name = "label3";
            label3.Size = new Size(141, 41);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(444, 194);
            label4.Name = "label4";
            label4.Size = new Size(108, 41);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 362);
            label5.Name = "label5";
            label5.Size = new Size(254, 41);
            label5.TabIndex = 4;
            label5.Text = "Confirmar Senha:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F);
            txtNome.Location = new Point(33, 66);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(345, 34);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14F);
            txtUsuario.Location = new Point(444, 66);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(345, 34);
            txtUsuario.TabIndex = 6;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 14F);
            txtTelefone.Location = new Point(33, 238);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(345, 34);
            txtTelefone.TabIndex = 7;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14F);
            txtSenha.Location = new Point(444, 238);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(345, 34);
            txtSenha.TabIndex = 8;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI", 14F);
            txtConfirmarSenha.Location = new Point(33, 406);
            txtConfirmarSenha.Multiline = true;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(345, 34);
            txtConfirmarSenha.TabIndex = 9;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Enabled = false;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(33, 525);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(250, 125);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(444, 525);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(250, 125);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(824, 764);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtTelefone);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCadastro";
            Text = "Cadastrar-se";
            FormClosed += frmCadastro_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtTelefone;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}