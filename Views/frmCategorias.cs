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
    public partial class frmCategorias : Form
    {
        private void AttTabela()
        {
            CategoryController controleCategoria = new CategoryController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategorias.DataSource = tabela;
        }

        public frmCategorias()
        {
            InitializeComponent();
        }
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            AttTabela();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            // classe     |  nome var    |   classe
            CategoryController controleCategoria = new CategoryController();

            //retorn func |nome var | nome func | parametros
            bool sucesso = controleCategoria.AddCategory(txtCategoria.Text);

            if (sucesso == true)
            {
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro durante o cadastro, tente novamente");
            }
            AttTabela();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int celulaID = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["Código"].Value);
            CategoryController controleCategoria = new CategoryController();

            bool sucesso = controleCategoria.DelCategoria(celulaID);

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
    }
}
