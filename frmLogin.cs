namespace Agenda_Telefonica
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lklCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro formularioCadastro = new frmCadastro();
            this.Hide();
            formularioCadastro.ShowDialog();
        }
    }
}
