namespace Agenda_Telefonica.Views
{
    partial class frmUsuarios
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
            dgvUsuarios = new DataGridView();
            btnDeletar = new Button();
            label2 = new Label();
            txtNovaSenha = new TextBox();
            label3 = new Label();
            txtConfirmarSenha = new TextBox();
            label4 = new Label();
            btnConfirmarSenha = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(378, 32);
            label1.TabIndex = 0;
            label1.Text = "DELETAR USUARIOS MUAHAHAHA";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 82);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(378, 259);
            dgvUsuarios.TabIndex = 1;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(113, 355);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(150, 50);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(482, 9);
            label2.Name = "label2";
            label2.Size = new Size(270, 32);
            label2.TabIndex = 3;
            label2.Text = "ALTERAR >SUA< SENHA";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(482, 100);
            txtNovaSenha.Multiline = true;
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(270, 67);
            txtNovaSenha.TabIndex = 4;
            txtNovaSenha.TextChanged += txtNovaSenha_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 82);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 5;
            label3.Text = "Digite sua nova senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(482, 222);
            txtConfirmarSenha.Multiline = true;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(270, 67);
            txtConfirmarSenha.TabIndex = 6;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 204);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 7;
            label4.Text = "Confirme sua senha";
            // 
            // btnConfirmarSenha
            // 
            btnConfirmarSenha.Enabled = false;
            btnConfirmarSenha.Location = new Point(549, 295);
            btnConfirmarSenha.Name = "btnConfirmarSenha";
            btnConfirmarSenha.Size = new Size(150, 50);
            btnConfirmarSenha.TabIndex = 8;
            btnConfirmarSenha.Text = "CONFIRMAR";
            btnConfirmarSenha.UseVisualStyleBackColor = true;
            btnConfirmarSenha.Click += btnConfirmarSenha_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(801, 417);
            Controls.Add(btnConfirmarSenha);
            Controls.Add(label4);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(label3);
            Controls.Add(txtNovaSenha);
            Controls.Add(label2);
            Controls.Add(btnDeletar);
            Controls.Add(dgvUsuarios);
            Controls.Add(label1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvUsuarios;
        private Button btnDeletar;
        private Label label2;
        private TextBox txtNovaSenha;
        private Label label3;
        private TextBox txtConfirmarSenha;
        private Label label4;
        private Button btnConfirmarSenha;
    }
}