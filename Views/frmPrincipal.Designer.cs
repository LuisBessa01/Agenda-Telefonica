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
            btnAgendaStripMenu = new ToolStripMenuItem();
            lblBemVindo = new Label();
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
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, btnAgendaStripMenu });
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
            // btnAgendaStripMenu
            // 
            btnAgendaStripMenu.Name = "btnAgendaStripMenu";
            btnAgendaStripMenu.Size = new Size(155, 26);
            btnAgendaStripMenu.Text = "&Agenda";
            btnAgendaStripMenu.Click += btnAgendaStripMenu_Click;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.Location = new Point(69, 57);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.RightToLeft = RightToLeft.No;
            lblBemVindo.Size = new Size(245, 54);
            lblBemVindo.TabIndex = 1;
            lblBemVindo.Text = "boas vindas";
            lblBemVindo.Click += lblBemVindo_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblBemVindo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            RightToLeft = RightToLeft.No;
            Text = "boas vindas";
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
        private Label lblBemVindo;
        private ToolStripMenuItem btnAgendaStripMenu;
    }
}