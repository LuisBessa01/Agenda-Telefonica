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
        private void AttTabela()
        {
            CategoryController controleCategoria = new CategoryController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategorias.DataSource = tabela;
        }
        public frmContatos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmContatos_Load(object sender, EventArgs e)
        {
            AttTabela();
        }
    }
}
