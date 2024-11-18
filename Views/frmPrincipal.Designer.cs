namespace Agenda_Telefonica.Views
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            btnCadastrarCategoria = new ToolStripMenuItem();
            btnCadastrarUsuarios = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            txtTeste = new TextBox();
            btnTeste = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnCadastrarCategoria, btnCadastrarUsuarios, categoriasToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(124, 22);
            cadastrarToolStripMenuItem.Text = "&Cadastrar";
            // 
            // btnCadastrarCategoria
            // 
            btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            btnCadastrarCategoria.Size = new Size(154, 22);
            btnCadastrarCategoria.Text = "Ca&tegorias";
            btnCadastrarCategoria.Click += btnCadastrarCategoria_Click;
            // 
            // btnCadastrarUsuarios
            // 
            btnCadastrarUsuarios.Name = "btnCadastrarUsuarios";
            btnCadastrarUsuarios.Size = new Size(154, 22);
            btnCadastrarUsuarios.Text = "&Usuários";
            btnCadastrarUsuarios.Click += btnCadastrarUsuarios_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(154, 22);
            categoriasToolStripMenuItem.Text = "maisoutracoisa";
            // 
            // txtTeste
            // 
            txtTeste.Location = new Point(137, 132);
            txtTeste.Name = "txtTeste";
            txtTeste.Size = new Size(100, 23);
            txtTeste.TabIndex = 1;
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(445, 184);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(75, 23);
            btnTeste.TabIndex = 2;
            btnTeste.Text = "button1";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTeste);
            Controls.Add(txtTeste);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            FormClosed += frmPrincipal_FormClosed;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem btnCadastrarCategoria;
        private ToolStripMenuItem btnCadastrarUsuarios;
        private TextBox txtTeste;
        private Button btnTeste;
    }
}