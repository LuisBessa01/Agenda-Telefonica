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
    public partial class frmContatos : Form
    {
        int celulaID;
        private void AttTabela()
        {
            CategoryController controleCategoria = new CategoryController();
            DataTable tabelaCategorias = controleCategoria.GetCategorias();

            cbxCategorias.DataSource = tabelaCategorias;
            cbxCategorias.DisplayMember = "Categorias";
            cbxCategorias.ValueMember = "Categorias";

            ContactsController controleContatos = new ContactsController();
            DataTable tabelaContatos = controleContatos.GetContacts();

            dgvContatos.DataSource = tabelaContatos;

        }
        public frmContatos()
        {
            InitializeComponent();
        }



        private void frmContatos_Load(object sender, EventArgs e)
        {
            AttTabela();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ContactsController controleContatos = new ContactsController();

            controleContatos.AddContact(txtNomeContato.Text, txtTelefoneContato.Text, cbxCategorias.Text);

            AttTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.celulaID = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells["Código"].Value);

            ContactsController controleContatos = new ContactsController();

            bool sucesso = controleContatos.DelContact(celulaID);

            if (sucesso == true)
            {
                MessageBox.Show("Contato deletado com sucesso");
            }
            else
            {
                MessageBox.Show("Houve um erro ao deletar o contato");
            }

            AttTabela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.celulaID = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells["Código"].Value);

            ContactsController controleContatos = new ContactsController();

            bool sucesso = controleContatos.UpdateContact(celulaID, txtNomeContato.Text, txtTelefoneContato.Text, cbxCategorias.Text);

            if (sucesso == true)
            {
                MessageBox.Show("Contato atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("Houve um erro ao atualizar o contato");
            }

            AttTabela();
        }
    }
}
