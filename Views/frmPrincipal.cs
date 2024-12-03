using Agenda_Telefonica.Data;
using Agenda_Telefonica.GlobalVar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBemVindo.Text = $"Seja bem vindo(a) {SessionAgenda.nome}";
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            frmCategorias formCategorias = new frmCategorias();

            formCategorias.ShowDialog();

        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios formUsuarios = new frmUsuarios();
            formUsuarios.ShowDialog();
        }

        private void btnAgendaStripMenu_Click(object sender, EventArgs e)
        {
            frmContatos formContatos = new frmContatos();
            formContatos.ShowDialog();
        }

        private void lblBemVindo_Click(object sender, EventArgs e)
        {

        }
    }
}
