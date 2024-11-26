namespace Agenda_Telefonica.Views
{
    partial class frmContatos
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
            txtNomeContato = new TextBox();
            txtTelefoneContato = new TextBox();
            dgvContatos = new DataGridView();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbxCategorias = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // txtNomeContato
            // 
            txtNomeContato.Location = new Point(46, 62);
            txtNomeContato.Multiline = true;
            txtNomeContato.Name = "txtNomeContato";
            txtNomeContato.Size = new Size(215, 37);
            txtNomeContato.TabIndex = 0;
            // 
            // txtTelefoneContato
            // 
            txtTelefoneContato.Location = new Point(46, 129);
            txtTelefoneContato.Multiline = true;
            txtTelefoneContato.Name = "txtTelefoneContato";
            txtTelefoneContato.Size = new Size(215, 36);
            txtTelefoneContato.TabIndex = 1;
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(373, 44);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(593, 498);
            dgvContatos.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(46, 371);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 100);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(161, 371);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 100);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(46, 477);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(215, 54);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 44);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome do Contato:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 111);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 183);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Categorias";
            // 
            // cbxCategorias
            // 
            cbxCategorias.FormattingEnabled = true;
            cbxCategorias.Location = new Point(46, 201);
            cbxCategorias.Name = "cbxCategorias";
            cbxCategorias.Size = new Size(215, 23);
            cbxCategorias.TabIndex = 10;
            // 
            // frmContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 610);
            Controls.Add(cbxCategorias);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvContatos);
            Controls.Add(txtTelefoneContato);
            Controls.Add(txtNomeContato);
            Name = "frmContatos";
            Text = "frmContatos";
            Load += frmContatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeContato;
        private TextBox txtTelefoneContato;
        private DataGridView dgvContatos;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Button btnEditar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbxCategorias;
    }
}