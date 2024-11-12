using Agenda_Telefonica.Controller;
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
    public partial class frmUsuarios : Form
    {
        public string userLogado;
        private void AttTabela()
        {
            UserController controleUsuarios = new UserController();
            DataTable tabela = controleUsuarios.GetUsers();
            dgvUsuarios.DataSource = tabela;
        }

        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void presencaCamposSenha()
        {
            bool possuiErro = false;
            if (txtNovaSenha.Text.Length < 8)
            {
                possuiErro = true;
            }
            if (txtConfirmarSenha.Text != txtNovaSenha.Text)
            {
                possuiErro |= true;
            }

            if (possuiErro)
            {
                btnConfirmarSenha.Enabled = false;
            }
            else
            {
                btnConfirmarSenha.Enabled = true;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(dgvUsuarios.SelectedRows[0].Cells["Usuário"].Value)!;

            UserController controleUsuario = new UserController();

            bool sucesso = controleUsuario.DelUser(usuario);

            if (sucesso == true)
            {
                MessageBox.Show("Categoria deletada com sucesso");
            }
            else
            {
                MessageBox.Show("Houve um erro ao deletar a categoria");
            }

            AttTabela();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            AttTabela();
            txtNovaSenha.Text = userLogado;
        }

        private void btnConfirmarSenha_Click(object sender, EventArgs e)
        {
            UserController controleUser = new UserController();

            controleUser.ModSenha(userLogado, txtNovaSenha.Text);
        }

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            presencaCamposSenha();
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            presencaCamposSenha();
        }
    }
}
