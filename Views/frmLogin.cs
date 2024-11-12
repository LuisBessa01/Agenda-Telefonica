using Agenda_Telefonica.Controller;
using Agenda_Telefonica.Views;

namespace Agenda_Telefonica
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void presencaCamposLogin()
        {
            if (txtUsuario.Text.Length > 0 && txtSenha.Text.Length >= 8)
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void lklCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro formularioCadastro = new frmCadastro();
            this.Hide();
            formularioCadastro.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            presencaCamposLogin();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            presencaCamposLogin();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UserController login = new UserController();

            bool sucesso = login.LoginUser(txtUsuario.Text, txtSenha.Text);

            if (sucesso == true)
            {
                frmUsuarios formUsuarios = new frmUsuarios();
                formUsuarios.userLogado = txtUsuario.Text;


                frmPrincipal formPrincipal = new frmPrincipal();
                this.Hide();
                formPrincipal.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Login errado");
            }

        }
    }
}
