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
            btnTeste2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(117, 26);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnCadastrarCategoria, btnCadastrarUsuarios, categoriasToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(155, 26);
            cadastrarToolStripMenuItem.Text = "&Cadastrar";
            // 
            // btnCadastrarCategoria
            // 
            btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            btnCadastrarCategoria.Size = new Size(192, 26);
            btnCadastrarCategoria.Text = "Ca&tegorias";
            btnCadastrarCategoria.Click += btnCadastrarCategoria_Click;
            // 
            // btnCadastrarUsuarios
            // 
            btnCadastrarUsuarios.Name = "btnCadastrarUsuarios";
            btnCadastrarUsuarios.Size = new Size(192, 26);
            btnCadastrarUsuarios.Text = "&Usuários";
            btnCadastrarUsuarios.Click += btnCadastrarUsuarios_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(192, 26);
            categoriasToolStripMenuItem.Text = "maisoutracoisa";
            // 
            // txtTeste
            // 
            txtTeste.Location = new Point(157, 176);
            txtTeste.Margin = new Padding(3, 4, 3, 4);
            txtTeste.Name = "txtTeste";
            txtTeste.Size = new Size(114, 27);
            txtTeste.TabIndex = 1;
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(509, 245);
            btnTeste.Margin = new Padding(3, 4, 3, 4);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(86, 31);
            btnTeste.TabIndex = 2;
            btnTeste.Text = "button1";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // btnTeste2
            // 
            btnTeste2.Location = new Point(218, 321);
            btnTeste2.Name = "btnTeste2";
            btnTeste2.Size = new Size(90, 54);
            btnTeste2.TabIndex = 3;
            btnTeste2.Text = "button2";
            btnTeste2.UseVisualStyleBackColor = true;
            btnTeste2.Click += btnTeste2_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnTeste2);
            Controls.Add(btnTeste);
            Controls.Add(txtTeste);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnTeste2;
    }
}