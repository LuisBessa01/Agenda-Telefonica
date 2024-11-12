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
        }
    }
}
